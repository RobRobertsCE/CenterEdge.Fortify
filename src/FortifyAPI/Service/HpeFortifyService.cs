using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using FortifyAPI.Model;
using System.Net.Http.Headers;

namespace FortifyAPI.Service
{
    public class HpeFortifyService
    {
        #region Constants
        private const string HpeUrlRoot = "https://api.ams.fortify.com";// "https://api.hpfod.com/api/v3/";
        private const string ReleasesEndpoint = "/api/v3/releases";
        private const string ReleaseVulnerabilitiesEndpoint = "/api/v3/releases/{0}/vulnerabilities";
        private const string ReleaseVulnerabilityDetailEndpoint = "/api/v3/releases/{0}/vulnerabilities/{1}/details";
        private const string AuthEndpoint = "oauth/token";
        private const string AuthScope = "api-tenant";
        private const string AuthGrantType = "client_credentials";
        #endregion

        #region Properties
        private HttpClient _client;
        protected HttpClient RestClient
        {
            get
            {
                if (null == _client)
                {
                    _client = new HttpClient();
                    _client.BaseAddress = new Uri(UrlRoot);
                    _client.DefaultRequestHeaders.Accept.Clear();
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return _client;
            }
        }
        protected string ClientId { get; set; }
        protected string ClientSecret { get; set; }
        protected string UrlRoot { get; set; } = HpeUrlRoot;
        protected string AuthToken { get; set; }
        #endregion

        #region Constructor
        public HpeFortifyService()
        {

        }

        public HpeFortifyService(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public HpeFortifyService(string clientId, string clientSecret, string authToken)
            : this(clientId, clientSecret)
        {
            AuthToken = authToken;
        }
        #endregion

        #region Public Methods
        public async Task<HpeRelease> GetLatestRelease()
        {
            await VerifyLoggedIn();

            var releases = await GetReleases(ReleasesEndpoint);

            return releases.items.OrderByDescending(r => r.releaseId).FirstOrDefault();
        }

        public async Task<IList<HpeVulnerability>> GetCurrentVulnerabilities(DateTime? createdSince)
        {
            IList<HpeVulnerability> vulnerabilityLists = new List<HpeVulnerability>();

            await VerifyLoggedIn();

            var release = await GetLatestRelease();

            var releaseEndpoint = String.Format(ReleaseVulnerabilitiesEndpoint, release.releaseId);

            var vulnerabilitiesResponse = await GetVulnerabilities(releaseEndpoint, createdSince); // TODO Implement filter - not supported by HPE yet.

            return vulnerabilitiesResponse.items;
        }

        public async Task<IList<HpeVulnerability>> GetVulnerabilityDetails(IList<HpeVulnerability> vulnerabilities)
        {
            foreach (var vulnerability in vulnerabilities)
            {
                vulnerability.Details = await GetVulnerabilityDetail(vulnerability.releaseId, vulnerability.vulnId);
            }

            return vulnerabilities;
        }

        public async Task<HpeVulnerabilityDetail> GetVulnerabilityDetail(int releaseId, string vulnerabilityId)
        {
            await VerifyLoggedIn();

            HpeVulnerabilityDetail detailResponse = null;
            var path = String.Format(ReleaseVulnerabilityDetailEndpoint, releaseId, vulnerabilityId);
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                detailResponse = await response.Content.ReadAsAsync<HpeVulnerabilityDetail>();
            }
            else
            {
                HandleResponseError(response);
            }
            return detailResponse;
        }
        #endregion

        #region Private Methods
        private async Task VerifyLoggedIn()
        {
            if (String.IsNullOrEmpty(AuthToken))
            {
                var loginResponse = await Login();
                if (String.IsNullOrEmpty(loginResponse))
                {
                    throw new HttpRequestException("Authentication failure");
                }
                AuthToken = loginResponse;
                RestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
            }
        }

        private async Task<string> Login()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            AuthToken = string.Empty;

            var authClient = new HttpClient
            {
                BaseAddress = new Uri(HpeUrlRoot)
            };
            authClient.DefaultRequestHeaders.Accept.Clear();
            authClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("scope", AuthScope),
                new KeyValuePair<string, string>("grant_type", AuthGrantType),
                new KeyValuePair<string, string>("client_id", ClientId),
                new KeyValuePair<string, string>("client_secret", ClientSecret)
            });

            try
            {
                HttpResponseMessage response = await authClient.PostAsync(AuthEndpoint, formContent);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var authResponse = await response.Content.ReadAsAsync<HpeAuthResponse>();
                    AuthToken = authResponse.access_token;
                }

                return AuthToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        private async Task<HpeReleasesResponse> GetReleases(string path)
        {
            HpeReleasesResponse releaseList = null;
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                Task<HpeReleasesResponse> taskResult = Task<HpeReleasesResponse>.Factory.StartNew(() => response.Content.ReadAsAsync<HpeReleasesResponse>().Result);
                var content = await response.Content.ReadAsStringAsync();
                releaseList = Newtonsoft.Json.JsonConvert.DeserializeObject<HpeReleasesResponse>(content);
            }
            else
            {
                HandleResponseError(response);
            }
            return releaseList;
        }

        private async Task<HpeVulnerabilitiesResponse> GetVulnerabilities(string path, DateTime? createdSince)
        {
            HpeVulnerabilitiesResponse vResponse = null;
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                vResponse = await response.Content.ReadAsAsync<HpeVulnerabilitiesResponse>();
            }
            else
            {
                HandleResponseError(response);
            }
            return vResponse;
        }

        private async void HandleResponseError(HttpResponseMessage response)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Error Response: {0}\r\n", response.ReasonPhrase);
            var errorResponse = await response.Content.ReadAsAsync<ErrorResponse>();
            if (null != errorResponse && null != errorResponse.Errors)
            {
                foreach (var errorItem in errorResponse.Errors)
                {
                    sb.AppendLine(String.Format("Error {0}: {1}", errorItem.ErrorCode, errorItem.Message));
                }
            }
            var exceptionMessage = sb.ToString();
            Console.WriteLine(exceptionMessage);
            throw new HttpRequestException(exceptionMessage);
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (null != _client) _client.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
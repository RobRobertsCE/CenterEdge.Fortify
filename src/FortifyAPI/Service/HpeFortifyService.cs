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
        private const string HpeUrlRoot = "https://api.ams.fortify.com";
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
        protected HpeAuthResponse AuthResponse { get; set; }
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
            AuthResponse.access_token = authToken;
        }
        #endregion

        #region Public Methods

        public async Task<HpeAuthResponse> Login()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            HpeAuthResponse authResponse = null;

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
                    AuthResponse = await response.Content.ReadAsAsync<HpeAuthResponse>();
                    //AuthToken = authResponse.access_token; // Token is good for 6 hours (21600 / 60 = 360; 360 / 60 = 6)
                }

                return AuthResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task<Release> GetLatestRelease()
        {
            await VerifyLoggedIn();

            var releases = await GetReleases(ReleasesEndpoint);

            return releases.OrderByDescending(r => r.ReleaseId).FirstOrDefault();
        }

        public async Task<IList<VulnerabilityListItem>> GetCurrentVulnerabilities(int releaseId, DateTime? createdSince)
        {
            await VerifyLoggedIn();

            var vulnerabilitiesEndpoint = String.Format(ReleaseVulnerabilitiesEndpoint, releaseId);

            return await GetVulnerabilities(vulnerabilitiesEndpoint, createdSince);
        }

        public async Task<IList<VulnerabilityDetails>> GetVulnerabilityDetails(IList<VulnerabilityListItem> vulnerabilities)
        {
            await VerifyLoggedIn();

            var details = new List<VulnerabilityDetails>();

            foreach (var vulnerability in vulnerabilities)
            {
                var path = String.Format(ReleaseVulnerabilityDetailEndpoint, vulnerability.ReleaseId.Value, vulnerability.VulnId);
                HttpResponseMessage response = await RestClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsAsync<VulnerabilityDetails>();
                    details.Add(content);
                }
                else
                {
                    HandleResponseError(response);
                }
            }

            return details;
        }

        public async Task<VulnerabilityDetails> GetVulnerabilityDetail(int releaseId, string vulnerabilityId)
        {
            await VerifyLoggedIn();

            VulnerabilityDetails content = null;
            var path = String.Format(ReleaseVulnerabilityDetailEndpoint, releaseId, vulnerabilityId);
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsAsync<VulnerabilityDetails>();
            }
            else
            {
                HandleResponseError(response);
            }
            return content;
        }
        #endregion

        #region Private Methods
        private async Task VerifyLoggedIn()
        {
            if (String.IsNullOrEmpty(AuthResponse?.access_token))
            {
                AuthResponse = await Login();
                if (String.IsNullOrEmpty(AuthResponse.access_token))
                {
                    throw new HttpRequestException("Authentication failure");
                }
                //AuthToken = loginResponse.access_token;
                RestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthResponse.access_token);
            }
        }

        private async Task<IList<Release>> GetReleases(string path)
        {
            IList<Release> releaseList = null;
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<ReleaseListResponse>();
                releaseList = content.Items;
            }
            else
            {
                HandleResponseError(response);
            }
            return releaseList;
        }

        private async Task<IList<VulnerabilityListItem>> GetVulnerabilities(string path, DateTime? createdSince)
        {
            IList<VulnerabilityListItem> vulnerabilities = null;
            HttpResponseMessage response = await RestClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<GetVulnerabilitiesResponseVulnerabilityListItem>();
                vulnerabilities = content.Items;
            }
            else
            {
                HandleResponseError(response);
            }
            return vulnerabilities;
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
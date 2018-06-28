using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortifyAPI.Api;
using FortifyAPI.Client;
using FortifyAPI.Model;
using FortifyAPI.Service;
using RestSharp.Authenticators;

namespace FortifyAPI.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _clientSecret = "BV?K3lIkzOX3beo^li9aB8{SJEN1MD";
        private string _clientId = "060a92f1-52ef-4b19-acfe-2dcf23ae8000";
        private string _authToken;
        DateTime _authExpiration = DateTime.Now;
        HpeAuthResponse _authResponse;

        public bool HasValidAuthToken
        {
            get
            {
                return (_authExpiration > DateTime.Now && !String.IsNullOrEmpty(_authResponse?.access_token));
            }
        }
        private async Task<string> GetAuthToken()
        {
            if (!HasValidAuthToken)
            {
                var service = new HpeFortifyService(_clientId, _clientSecret);
                _authResponse = await service.Login();
                _authExpiration = DateTime.Now.AddSeconds(Int32.Parse(_authResponse.expires_in));
            }
            return _authResponse.access_token;
        }
        private async Task<Configuration> GetConfiguration()
        {
            var token = await GetAuthToken();
            var config = new Configuration();
            config.DefaultHeader.Add("Authorization", string.Format("Bearer {0}", token));
            return config;
        }

        private async void button1_Click(object sender, EventArgs ea)
        {
            try
            {
                try
                {
                    var service = new HpeFortifyService(_clientId, _clientSecret);
                    var authResponse = service.Login();

                    var release = await service.GetLatestRelease();

                    var vulnerabilities = await service.GetCurrentVulnerabilities(release.ReleaseId.Value, null);

                    dataGridView1.DataSource = vulnerabilities;
                }
                catch (Exception e)
                {
                    Debug.Print("Exception when calling ApplicationMonitoringApi.ApplicationMonitoringV3GetApplicationMonitoringConfiguration: " + e.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var config = await GetConfiguration();
                var releasesService = new ReleasesApi(config);
                var releases = releasesService.ReleasesV3GetReleases();
                var latestRelease = releases.Items.OrderBy(r => r.ReleaseId).FirstOrDefault();

                var vulnerabilityService = new VulnerabilitiesApi(config);
                var vulnerabilities = await vulnerabilityService.VulnerabilitiesV3GetVulnerabilitiesAsync(latestRelease.ReleaseId);

                dataGridView1.DataSource = vulnerabilities;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}

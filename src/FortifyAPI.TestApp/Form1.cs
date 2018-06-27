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

namespace FortifyAPI.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs ea)
        {
            try
            {
                try
                {

                    var secret = "BV?K3lIkzOX3beo^li9aB8{SJEN1MD";
                    var id = "060a92f1-52ef-4b19-acfe-2dcf23ae8000";
                    var service = new HpeFortifyService(id, secret);

                    //var release = await service.GetLatestRelease();

                    var vulnerabilities = await service.GetCurrentVulnerabilities(null);
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
    }
}

using FoursquareAPI.Models;
using InitService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Tmob.WinForms
{
    public partial class Form1 : Form
    {
        public string appVersion = ConfigurationManager.AppSettings["applicationVersion"]; // get app version from config file.
        public string mode = ConfigurationManager.AppSettings["mode"]; // get mode from config file 0 = Test , 1 = Production.
        public bool isModeTest;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (mode == "0") { isModeTest = true; } else { isModeTest = false; } // If mode 0 then I add T variable to venues name.
            using (WebClient client = new WebClient())
            {
                string value = client.DownloadString("http://localhost:62697/api/init?versionOfApp=" + appVersion); // get needsUpdate value from init service.

                InitModels model = JsonConvert.DeserializeObject<InitModels>(value); // deserialize to our model

                isVersionOK = Convert.ToBoolean(model.needsUpdate);
                if (isVersionOK == false)
                {
                    MessageBox.Show("Your app version(" + appVersion + ") is greater than 1.1.3. ");
                }
                else
                {
                    MessageBox.Show("Warning! Your app version(" + appVersion + ") is less than 1.1.3. You can change it from App.Config");
                }
            }
        }

        public bool isVersionOK;
        public List<VenueModel.Venue> Companies { get; set; }
        private void btnGetCompanies_Click(object sender, EventArgs e)
        {
            bool isChecked = checkValidation();
            if (isChecked != false)
            {
                using (HttpClient client = new HttpClient())
                {

                    string value = client.GetStringAsync("http://localhost:54325/api/venue?query=" + txtQuery.Text.ToString() + "&near=" + txtCity.Text.ToString() + "&latLong=" + txtLL.Text.ToString()).Result;

                    Companies = JsonConvert.DeserializeObject<List<VenueModel.Venue>>(value);

                    if (isModeTest == true) // if its test app.Then add venue's name a T variable
                    {
                        foreach (var item in Companies)
                        {
                            item.name = "T" + item.name;
                        }
                    }

                    fillListBox(Companies);
                    listBox_Companies.DisplayMember = "name";
                }

            }


        }

        private bool checkValidation() // query , city and lat,long validation 
        {
            string query = txtQuery.Text.ToString();
            string city = txtCity.Text.ToString();
            string ll = txtLL.Text.ToString();

            if (query == string.Empty)
            {
                MessageBox.Show("Please enter the search value.");
                return false;
            }
            if ((city == string.Empty && ll == string.Empty) || (city != string.Empty && ll != string.Empty))
            {
                MessageBox.Show("Please enter the city name or latitude,longitute value.");
                return false;
            }
            return true;
        }

        private void fillListBox(List<VenueModel.Venue> companies)
        {
            listBox_Companies.Items.Clear();
            var ordered = companies.OrderBy(x => x.name).ToList();
            ordered.ForEach(x => listBox_Companies.Items.Add(x));
        }

        public VenueModel.Venue SelectedCompany { get; set; }
        private void listBox_Companies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Companies.SelectedItem == null) return;
            SelectedCompany = listBox_Companies.SelectedItem as VenueModel.Venue;
            clearLabels();
            lbl_Name.Text += SelectedCompany.name;
            lbl_City.Text += SelectedCompany.location.city;
            lbl_Country.Text += SelectedCompany.location.country;

            if (SelectedCompany.url == null) // if the url value is null then 
            {
                lbl_Url.Text += "https://www.google.com";
            }
            lbl_Url.Text += SelectedCompany.url;
            lbl_People.Text += SelectedCompany.herenow.count;

        }

        private void clearLabels()
        {
            lbl_City.Text = "City : ";
            lbl_Country.Text = "Country : ";
            lbl_Name.Text = "Name : ";
            lbl_Url.Text = "URL : ";
            lbl_People.Text = "People Here Now : ";
        }
    }
}

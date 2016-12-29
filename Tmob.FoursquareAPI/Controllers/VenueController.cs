using FoursquareAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace FoursquareAPI.Controllers
{
    public class VenueController : ApiController
    {
        public const string clientID = ""; // Create a foursquare app then take these values. 
        public const string clientSecret = "";
        public string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        string version = DateTime.Today.ToString("yyyyMMdd");
        public string jsonString = string.Empty;

        public List<VenueModel.Venue> Get(string query, string near, string latLong)
        {
            if (near != null) // if city value entered by user
            {
                apiUrl += "&query=" + query + "&client_id=" + clientID + "&client_secret=" + clientSecret + "&v=" + version + "&near=" + near;
            }
            else
            {
                apiUrl += "&query=" + query + "&client_id=" + clientID + "&client_secret=" + clientSecret + "&v=" + version + "&ll=" + latLong;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    jsonString = client.GetStringAsync(apiUrl).Result;
                }
                catch { }
            }

            VenueModel model = JsonConvert.DeserializeObject<VenueModel>(jsonString);
            if (model == null)
            {
                return new List<VenueModel.Venue>() { };
            }

            return model.response.venues.ToList();
        }

        // POST: api/Venue
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Venue/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Venue/5
        public void Delete(int id)
        {
        }
    }
}

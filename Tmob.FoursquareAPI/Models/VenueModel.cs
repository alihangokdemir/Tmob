using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoursquareAPI.Models
{
    public class VenueModel
    {
        public class Location
        {
            public double lat { get; set; }
            public double lng { get; set; }
            public string city { get; set; }
            public string country { get; set; }
        }

        public class Venue
        {
            public string id { get; set; }
            public string name { get; set; }
            public int peopleHereNow { get; set; }
            public string url { get; set; }
            public Location location { get; set; }
            public HereNow herenow { get; set; }
        }

        public class HereNow
        {
            public int count { get; set; }
        }

        public class Response
        {
            public List<Venue> venues { get; set; }
        }

        public Response response { get; set; }
        public Venue venue { get; set; }


    }
}
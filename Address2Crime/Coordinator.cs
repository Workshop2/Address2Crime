using System;
using System.Collections.Generic;
using System.Linq;
using Geocoding;
using Geocoding.Google;
using PoliceUk;

namespace Address2Crime
{
    public class Coordinator
    {
        public Geoposition GetCoordinatesFromAddress(string address)
        {
            IGeocoder geocoder = new GoogleGeocoder();// { ApiKey = "this-is-my-optional-google-api-key" };
            IEnumerable<Address> addresses = geocoder.Geocode(address);

            Address detectedAddress = addresses.First();
            return new Geoposition(detectedAddress.Coordinates.Latitude, detectedAddress.Coordinates.Longitude);
        }
    }
}
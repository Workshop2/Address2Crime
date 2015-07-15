using System;
using PoliceUk;
using PoliceUk.Entities.StreetLevel;

namespace Address2Crime
{
    public class CrimeDetector
    {
        public StreetLevelCrimeResults GetCrimesForLocationThisYear(Geoposition geoposition)
        {
            var policeClient = new PoliceUkClient();
            return policeClient.StreetLevelCrimes(geoposition, new DateTime(2015, 05, 01));
        }
    }
}
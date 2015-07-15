using NUnit.Framework;
using PoliceUk;
using PoliceUk.Entities.StreetLevel;
using Should;
using SpecsFor;

namespace Address2Crime
{
    public class CrimeDetectorTests : SpecsFor<CrimeDetector>
    {
        public StreetLevelCrimeResults Result { get; set; }
        private readonly Geoposition _geoposition = new Geoposition(51.4902435, -0.3005307);

        protected override void When()
        {
            Result = SUT.GetCrimesForLocationThisYear(_geoposition);
        }

        [Test]
        public void then_should_return_data()
        {
            Result.ShouldNotBeNull();   
        }
    }
}
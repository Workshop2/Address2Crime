using NUnit.Framework;
using PoliceUk;
using Should;
using SpecsFor;

namespace Address2Crime
{
    public class Example : SpecsFor<Coordinator>
    {
        public Geoposition Result { get; set; }
        private readonly string Address = "302 Laval House, Ealing Road, Brentford, TW8 0GL";
        
        protected override void When()
        {
            Result = SUT.GetCoordinatesFromAddress(Address);
        }

        [Test]
        public void then_should_return_data()
        {
            Result.ShouldNotBeNull();
            Result.Latitude.ShouldNotEqual(0);
            Result.Latitude.ShouldNotEqual(0);
        }
    }
}

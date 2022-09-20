using Microsoft.VisualStudio.TestTools.UnitTesting;
using SourceWebApi;

namespace SourceWebApiTests
{
    [TestClass]
    public class WeatherServiceTests
    {
        [DataRow(-15, "Freezing")]
        [DataRow(-7, "Bracing")]
        [DataRow(3, "Chilly")]
        [DataRow(8, "Cool")]
        [DataRow(11, "Mild")]
        [DataRow(16, "Warm")]
        [DataRow(24, "Balmy")]
        [DataRow(27, "Hot")]
        [DataRow(32, "Sweltering")]
        [DataRow(39, "Scorching")]
        [TestMethod]
        public void GetDescription_GivenTemperatureCelsius_ReturnsDescription(double temperature, string expected)
        {
            var actual = WeatherService.GetDescription(temperature);

            Assert.AreEqual(expected, actual);
        }
    }
}

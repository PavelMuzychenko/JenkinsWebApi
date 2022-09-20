using JenkinsWebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SourceWebApiTests
{
    [TestClass]
    public class WeatherForecastTests
    {
        [DataRow(-1, 30.2)]
        [DataRow(-10, 14)]
        [DataRow(7, 44.6)]
        [DataRow(18, 64.4)]
        [DataRow(24, 75.2)]
        [TestMethod]
        public void TemperatureFahrenheit_GivenTemperatureCelsius_ConvertsCorrectly(double celsius, double expectedFahrenheit)
        {
            var wf = new WeatherForecast { TemperatureCelsius = celsius };

            Assert.AreEqual(expectedFahrenheit, wf.TemperatureFahrenheit);
        }
    }
}
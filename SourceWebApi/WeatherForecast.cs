namespace JenkinsWebApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public double TemperatureCelsius { get; set; }

        public double TemperatureFahrenheit => 32 + TemperatureCelsius * 1.8;

        public string? Description { get; set; }
    }
}
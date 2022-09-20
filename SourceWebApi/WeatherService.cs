namespace SourceWebApi
{
    public class WeatherService
    {
        public static string GetDescription(double temperature) => temperature switch
        {
            <= -10 => "Freezing",
            > -10 and <=0 => "Bracing",
            > 0 and <=5 => "Chilly",
            > 5 and <=10 => "Cool",
            > 10 and <=15 => "Mild",
            > 15 and <=20 => "Warm",
            > 20 and <=25 => "Balmy",
            > 25 and <=30 => "Hot",
            > 30 and <=35 => "Sweltering",
            > 35 => "Scorching",
            _ => throw new ArgumentException()
        };       
    }
}

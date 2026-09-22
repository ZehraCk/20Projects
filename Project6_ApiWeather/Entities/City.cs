namespace Project6_ApiWeather.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
        public decimal Temp { get; set; }
        public string Detail { get; set; }
    }
}

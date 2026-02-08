namespace ASPNET_MVC_DEMO.Models
{
    public class MapModel
    {
        public int Zoom { get; set; }
        public string Lat { get; set; } 
        public string Lng { get; set; }

        public static MapModel Default => new MapModel
        {
            Zoom = 13,
            Lat = 50.327925.ToString(),
            Lng = 26.5119475.ToString()
        };
    }
}

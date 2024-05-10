using System.Text.Json.Serialization;

namespace AppDemo.Models
{
    public class Address
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string attn { get; set; }
    }

    public class Current
    {
        public string callsign { get; set; }
        public string operClass { get; set; }
    }

    public class Location
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string gridsquare { get; set; }
    }

    public class OtherInfo
    {
        public string grantDate { get; set; }
        public string expiryDate { get; set; }
        public string lastActionDate { get; set; }
        public string frn { get; set; }
        public string ulsUrl { get; set; }
    }

    public class Previous
    {
        public string callsign { get; set; }
        public string operClass { get; set; }
    }

    public class MyJsonObject
    {
        public string status { get; set; }
        public string type { get; set; }
        public Current current { get; set; }
        public Previous previous { get; set; }
        public Trustee trustee { get; set; }
        public string name { get; set; }
        public Address address { get; set; }
        public Location location { get; set; }
        public OtherInfo otherInfo { get; set; }
    }

    public class Trustee
    {
        public string callsign { get; set; }
        public string name { get; set; }
    }

}

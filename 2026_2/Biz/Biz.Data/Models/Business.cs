namespace Biz.Data.Models
{
    public class Business
    {
        public int Age { get; set; }       

        public double CustomerRating { get; set; }       

        public BusinessType Type { get; set; }

        public double AnnualRevenue { get; set; }

        public override string ToString()
        {
            return $"{Type.Name} - ${AnnualRevenue}";
        }
    }
}

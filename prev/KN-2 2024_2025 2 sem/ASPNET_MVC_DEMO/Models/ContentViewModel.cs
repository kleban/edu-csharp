
using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC_DEMO.Models
{
    public class ContentViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //[AllowHtml]
        [DataType(DataType.Html)]
        public string Contents { get; set; }
        public byte[] Image { get; set; }
    }
}

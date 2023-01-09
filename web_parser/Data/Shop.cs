using System.ComponentModel.DataAnnotations;

namespace web_parser.Data
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
}

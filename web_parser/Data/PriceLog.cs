using System.ComponentModel.DataAnnotations.Schema;

namespace web_parser.Data
{
    public class PriceLog
    {
        [Column(TypeName = "datetime")]
        public DateTime Timer { get; set; }

        public int ShopId { get; set; }

        public int ProductId { get; set; }

        public double Price { get; set; }
    }
}

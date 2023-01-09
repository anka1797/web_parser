using System.ComponentModel.DataAnnotations;

namespace web_parser.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }
    }
}

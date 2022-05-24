using System.ComponentModel.DataAnnotations;

namespace my_api.Models
{
    public class Exchanges
    {
        [Key]
        public string ExchangeID { get; set; }

        public string Exchange { get; set; }
    }
}

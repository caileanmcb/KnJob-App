using System.ComponentModel.DataAnnotations;

namespace my_api.Models
{
    public class Exchanges
    {
        [Key]
        public int ExchangeID { get; set; }
        
        [Required]
        public string Exchange { get; set; }
    }
}

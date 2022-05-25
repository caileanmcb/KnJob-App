using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_api.Models
{
    public class Values
    {
        [Key]
        public int CodeID { get; set; }
        [Required]
        public string Code_name { get; set; }

        public int? Value { get; set; }
    }
}

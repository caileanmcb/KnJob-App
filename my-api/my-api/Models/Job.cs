using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_api.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar(65)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName="nvarchar(65)")]
        public string Type { get; set; }
    }
}

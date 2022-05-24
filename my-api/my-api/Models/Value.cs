namespace my_api.Models
{
    public class Values
    {
        [Key]
        public string CodeID { get; set; }

        public string Code_name { get; set; }

        public int? Value { get; set; }
    }
}

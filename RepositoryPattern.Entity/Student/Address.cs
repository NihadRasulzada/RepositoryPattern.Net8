using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity.Student
{
    public class Address
    {
        public Guardian Guardian { get; set; }
        [Key, ForeignKey("Guardian")]
        public int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        public string Adress2 { get; set; }

        [StringLength(10)]
        public int PostCode { get; set; }
    }
}

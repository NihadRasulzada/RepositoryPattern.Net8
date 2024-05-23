using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity.Student
{
    public class GuardianType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public IList<Guardian> Guardians { get; set; }
    }
}

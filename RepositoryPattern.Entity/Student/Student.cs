using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity.Student
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255, MinimumLength = 3)]
        [Required]
        public string FName { get; set; }
        [StringLength(255, MinimumLength = 3)]
        [Required]
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public Family Family { get; set; }
        public int FamilyId { get; set; }
    }
}

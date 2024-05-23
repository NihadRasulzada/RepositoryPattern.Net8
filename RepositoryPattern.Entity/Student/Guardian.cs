using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity.Student
{
    public class Guardian
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string FName { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string LName { get; set; }
        [Required]
        [StringLength(254, MinimumLength = 3)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        public Family Family { get; set; }
        public int FamilyId { get; set; }

        public Address Address { get; set; }

        public GuardianType GuardianType { get; set; }
        public int GuardianTypeId { get; set; }
    }
}

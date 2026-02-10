using System.ComponentModel.DataAnnotations;

namespace EMPLOYEEMANAGEMENT.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string EmailId { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string MobileNo { get; set; } = string.Empty;
    }
}

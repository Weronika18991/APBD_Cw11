using System.ComponentModel.DataAnnotations;

namespace Cw11.DTOs
{
    public class AddDoctorRequest
    {
        [Required(ErrorMessage = "Musisz podac ID")]
        public int IdDoctor { get; set; }
        [Required(ErrorMessage = "Musisz podac Imie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Musisz podac Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Musisz podac Email")]
        public string Email { get; set; }
    }
}
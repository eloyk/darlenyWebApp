using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace darlenyWebApp.Models.WebApp
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        [StringLength(256, ErrorMessage =
             "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 3)]
        public string UserName { get; set; }

        [NotMapped]
        [Display(Name = "User")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [Column("FirstName")]
        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage =
             "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 3)]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage =
            "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 3)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [StringLength(11, ErrorMessage =
            "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 10)]
        [Display(Name = "Telefono o Celular")]
        public string Phone { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }
    }
}

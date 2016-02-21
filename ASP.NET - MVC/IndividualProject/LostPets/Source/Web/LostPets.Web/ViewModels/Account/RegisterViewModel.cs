namespace LostPets.Web.ViewModels.Account
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using Data.Models.Types;

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [StringLength(30)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [DefaultValue(Gender.NotGiven)]
        public Gender Gender { get; set; }

        [Display(Name = "City")]
        [DefaultValue(City.NotGiven)]
        public City City { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "The phone number must be exactly 10 digits. ")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        [Display(Name = "Facebook Profile")]
        public string FacebookProfile { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}

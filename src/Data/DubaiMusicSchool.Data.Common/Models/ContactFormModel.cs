namespace DubaiMusicSchool.Data.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ContactFormModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }

        public string ReCaptcha { get; set; }
    }
}

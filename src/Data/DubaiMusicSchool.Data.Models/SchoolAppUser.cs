namespace DubaiMusicSchool.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using DubaiMusicSchool.Common;

    public class SchoolAppUser : ApplicationUser
    {
        [MaxLength(GlobalConstants.PersonNameMaxLength)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(GlobalConstants.PersonNameMaxLength)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}

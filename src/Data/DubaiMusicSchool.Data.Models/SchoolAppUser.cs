namespace DubaiMusicSchool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using DubaiMusicSchool.Common;

    public class SchoolAppUser : ApplicationUser
    {
        public SchoolAppUser()
        {
            this.Lessons = new HashSet<Lesson>();
            this.LessonCredits = 1;
        }

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

        public virtual ICollection<Lesson> Lessons { get; set; }

        public int LessonCredits { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }
    }
}

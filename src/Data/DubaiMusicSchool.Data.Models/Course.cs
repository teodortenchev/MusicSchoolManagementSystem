namespace DubaiMusicSchool.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using DubaiMusicSchool.Data.Common.Models;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please upload a picture for this course")]
        public string Picture { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

﻿namespace DubaiMusicSchool.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using DubaiMusicSchool.Data.Common.Models;

    public class Courses : BaseDeletableModel<int>
    {
        public Courses()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please upload a picture for this course")]
        public string Picture { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
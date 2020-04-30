namespace DubaiMusicSchool.Data.Models
{
    using System;

    using DubaiMusicSchool.Data.Common.Models;

    public class Lesson : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string StudentId { get; set; }

        public SchoolAppUser Student { get; set; }
    }
}

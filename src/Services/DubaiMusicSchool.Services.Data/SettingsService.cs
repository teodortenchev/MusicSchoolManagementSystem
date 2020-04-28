﻿namespace DubaiMusicSchool.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using DubaiMusicSchool.Data.Common.Repositories;
    using DubaiMusicSchool.Data.Models;
    using DubaiMusicSchool.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Courses> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Courses> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}

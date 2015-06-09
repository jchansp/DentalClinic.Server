﻿using Repositories;

namespace Entities
{
    public class Patient : User
    {
        public override void Register()
        {
            Patients.Persist(ToRepository());
        }

        private Repositories.Patient ToRepository()
        {
            return new Repositories.Patient
            {
                Id = Id,
                FirstName = FirstName
            };
        }
    }
}
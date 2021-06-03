using IntroductionToAspMVC.Models;
using System;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Services
{
    public class UserService : IUserService
    {
        public List<User> GetUsers()
        {
            string[] skills = { "C#", "JavaScript", "Sql", "Unity", "Teaching" };

            return new List<User>{
                    new User
                    {
                        Id = 1,
                        Name = "Michiel",
                        LastName = "Wouters",
                        DateOfBirth = new DateTime(1900, 1, 1),
                        Skills = skills
                    },
                    new User
                    {
                        Id = 2,
                        Name = "Jos",
                        LastName = "VanHoek",
                        DateOfBirth = new DateTime(1980, 5, 20),
                        Skills = skills
                    },
                    new User
                    {
                        Id = 3,
                        Name = "Jef",
                        LastName = "VanCirkel",
                        DateOfBirth = new DateTime(1998, 2, 12),
                        Skills = skills
                    }
               };
        }
    }
}
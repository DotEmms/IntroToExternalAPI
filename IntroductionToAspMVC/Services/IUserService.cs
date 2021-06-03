using IntroductionToAspMVC.Models;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
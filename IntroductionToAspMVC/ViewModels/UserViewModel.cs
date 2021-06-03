using IntroductionToAspMVC.Models;
using System.Collections.Generic;

namespace IntroductionToAspMVC.ViewModels
{
    public class UserViewModel
    {
        public ICollection<User> Users { get; set; }
    }
}
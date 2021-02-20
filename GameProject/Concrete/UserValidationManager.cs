using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}

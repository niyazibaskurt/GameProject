using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1987 && gamer.FirstName == "Niyazi"
                && gamer.LastName == "Başkurt" && gamer.IdentityNumber == 13253708920)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Name == "Salih Bora" && gamer.LastName == "Öztürk")
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

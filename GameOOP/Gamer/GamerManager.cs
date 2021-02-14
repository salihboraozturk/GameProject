using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validation(gamer)==true)
            {
                Console.WriteLine(gamer.Name+" kayıt başarılı.");
            }
            else{
                Console.WriteLine(gamer.Name+" doğrulama başarısız.");

            }
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}

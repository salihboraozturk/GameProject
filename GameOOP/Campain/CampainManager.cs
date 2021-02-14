using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine(campain.CampainName+" kampanyası başarıyla eklenmiştir.");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine(campain.CampainName+" kampanyası başarıyla silinmiştir.");
        }

        public void Update(Campain campain)
        {
           Console.WriteLine(campain.CampainName + " kampanyası başarıyla güncellenmiştir.");
        }
    }
}

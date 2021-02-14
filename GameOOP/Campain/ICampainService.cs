using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    interface ICampainService
    {
        void Add(Campain campain);
        void Update(Campain campain);
        void Delete(Campain campain);
    }
}

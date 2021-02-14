using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla sisteme eklenmiştir.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla silinmiştir.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla güncellenmiştir.");
        }
    }
}

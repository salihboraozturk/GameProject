using System;

namespace GameOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Id=1,Name="Salih Bora",LastName="Öztürk",BirthYear="1999",IdentityNumber="00000000000" };
            Game game = new Game() {GameId=1,GameName="Crossfire"};
            Campain campain = new Campain() {CampainId=1,CampainName="BlackFriday"};

            GamerManager gamerManager = new GamerManager(new GamerValidationManager()) { };
            gamerManager.Add(gamer);
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            CampainManager campainManager = new CampainManager();
            campainManager.Add(campain);
            SalesManager sales = new SalesManager();
            sales.Sell(gamer,game,campain);

        }
    }
}

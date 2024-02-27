using GameProject;

class Program
{
    public static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager()); //Kimlik doğrulaması için belirtildi.

        Gamer gamer1 = new Gamer();
        gamer1.Id = 1;
        gamer1.FirstName = "Niyazi";
        gamer1.LastName = "Başkurt";
        gamer1.BirthYear = 1987;
        gamer1.IdentityNumber = 13253708920;

        Gamer gamer2 = new Gamer();
        gamer2.Id = 2;
        gamer2.FirstName = "Alperen";
        gamer2.LastName = "Başkurt";
        gamer2.BirthYear = 2020;
        gamer2.IdentityNumber = 43631112360;

        gamerManager.Add(gamer1);

        Game game1 = new Game();
        game1.GameId = 1;
        game1.GameName = "Mortal Combat";
        game1.GamePrice = 100;

        Game game2 = new Game();
        game2.GameId = 2;
        game2.GameName = "FIFA";
        game2.GamePrice = 500;

        GameSalesManager gameSalesManager = new GameSalesManager();
        gameSalesManager.Sale(gamer2, game2);

    }

}
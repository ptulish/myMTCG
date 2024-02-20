using server1.DB;

namespace MyServer.Classes;

public class User
{
    public int user_id { get; set; }
    public string? Username { get; set; }
    public string Password { get; set; }
    public int Coins { get; set; }
    public int Elo { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Games { get; set; }
    public List<Card>? Deck { get; set; }
    public List<Card>? MyStack { get; set; }
    public User(int User_id, string username, string password, int coins, int elo, int draws ,int wins, int games)
    {
        user_id = User_id;
        Username = username;
        Password = password;
        Coins = coins;
        Deck = getDeck(user_id);
        MyStack = getMyStack(user_id);
        Elo = elo;
        Wins = wins;
        Draws = draws;
        Games = games;
    }

    public User()
    {
        
    }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        Coins = 20;
        Deck = new List<Card>();
        MyStack = new List<Card>();
        Elo = 100;
        Wins = 0;
        Draws = 0;
        Games = 0;
    }

    private List<Card> getMyStack(int userId)
    {
        return new List<Card>(); //DbCommands.getCardsFromUser(userId);
    }

    private List<Card> getDeck(int userId)
    {
        return new List<Card>();
    }
}
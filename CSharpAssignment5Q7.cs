using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Player
{
    public string PlayerName
    {
        get;
        set;
    }
    public int PlayerRuns
    {
        get;
        set;
    }

    public Player()
    {

    }
    public Player(string PlayerName, int PlayerRuns)
    {
        this.PlayerName = PlayerName;
        this.PlayerRuns = PlayerRuns;
    }
}

class Team : IEnumerable
{
    public int n
    {
        get;
        set;
    }
    Player[] players;

    public Team()
    {

    }
    public Team(int n)
    {
        this.players = new Player[n];
    }

    public void Add(int i)
    {
        this.players[i] = new Player();

        Console.WriteLine("Enter Player name");
        this.players[i].PlayerName = Console.ReadLine();

        Console.WriteLine("Enter Player runs");
        this.players[i].PlayerRuns = int.Parse(Console.ReadLine());

    }
    public void Display(int i)
    {

        Console.WriteLine("Player name = {0} and Player runs = {1}", this.players[i].PlayerName, this.players[i].PlayerRuns);

    }

    public IEnumerator GetEnumerator()
    {
        return players.GetEnumerator();
    }

}
class Actual
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the number of players");
        int n = int.Parse(Console.ReadLine());

        Team India = new Team(n);
        for (int i = 0; i < n; i++)
        {
            India.Add(i);
        }
        
        //Use Iterator to Iterate through the players
        for(int i = 0; i < n; i++)
        {
            India.Display(i);
        }
    }
}

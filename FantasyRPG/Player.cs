using System.Dynamic;

namespace FantasyRPG;

public class Player
{
    public string Name {get; set;}
    public string Element {get; set;}
    public List<Spells> Grimoire {get; set;}
    public double Health {get; set;}
    public double Energy {get; set;}
    public string PlayerBio {get; set;}
    public double XP {get; set;}
    public int Level => PlayerLevel(XP);
    
    public Player(string playerName, string playerElement)
    {   
        Name = playerName;
        Element = playerElement;
        Grimoire = new List<Spells>();
        Health = 100;
        Energy = 100;
        PlayerBio = "";
        XP = 0;
    }

    public void AskPlayerName()
    {
        Console.WriteLine("Enter your player name. Name should only consist of letters:");
        Name = Console.ReadLine()!;
    }

    public void SelectElement()
    {
        Console.WriteLine("Select an Element from the following: Water, Fire, Earth, Air or Spirit. Choose carefully as you will not be able to change your element:");
        Element = Console.ReadLine()!;
    }

    public void CreateBaseGrimoire()
    {   
        var playerBaseSpells = SpellLibrary.AllPlayerSpells.Where(s => s.SpellElement == Element && s.BaseSpell);

        Grimoire.AddRange(playerBaseSpells);
    }

    public string PlayerInformation()
    {
        PlayerBio =
            $"\nName: {Name}"+
            $"Element: {Element}"+
            $"Health = {Health} Energy = {Energy}";
        
        return PlayerBio;
    }

    public int PlayerLevel(double xp) => xp switch
    {
        <= 100 => 1,
        <= 225 => 2,
        <= 375 => 3,
        <= 550 => 4,
        > 550 => 5,
        _ => 0
    };
}
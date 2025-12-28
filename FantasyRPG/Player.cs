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
    public int Level {get; set;}

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
            $"\nElement: {Element}"+
            $"\nHealth = {Health} Energy = {Energy}";
        
        return PlayerBio;
    }

    public void UpdatePlayerLevel(Player player)
    {
        while (player.Level < 6)
        {
            
        }
    }
}
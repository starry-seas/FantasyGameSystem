namespace FantasyRPG;

public class Player
{
    public string Name {get; set;}
    public string Element {get; set;}
    public List<Spells> Grimoire {get; set;}
    public List<int> PlayerStats {get; set;}
    public string PlayerBio {get; set;}
    public int XP {get; set;}

    public Player(string playerName, string playerElement)
    {   
        Name = playerName;
        Element = playerElement;
        Grimoire = new List<Spells>();
        PlayerStats = new List<int>();
        PlayerBio = "";
        XP = 0;
    }

    public void AddBaseStats()
    {
        int health = 100;
        int energy = 100;
        
        PlayerStats.Add(health);
        PlayerStats.Add(energy);
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
            $"\nHealth = {PlayerStats[0]} Energy = {PlayerStats[1]}";
        
        return PlayerBio;
    }
}
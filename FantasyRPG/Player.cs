public class Player
{
    public string Name {get; set;}
    public string Element {get; set;}
    public List<Spells> Grimoire {get; set;}
    public List<int> PlayerStats {get; set;}

    public Player(string playerName, string playerElement)
    {   
        Name = playerName;
        Element = playerElement;
        Grimoire = new List<Spells>();
        PlayerStats = new List<int>();
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
        Spells heal = new Spells("Recover Health", "Spirit", 1, false);
        Spells light = new Spells("Light", "Fire", 1, false);
        Spells arcaneBolt = new Spells("Arcane Bolt", "Spirit", 1, true);
        
        Grimoire.Add(heal);
        Grimoire.Add(light);
        Grimoire.Add(arcaneBolt);

        if (Element == "Water")
        {
            AssignWaterSpells();
        }
        else if(Element == "Fire")
        {
            AssignFireSpells();
        }
        else if(Element == "Earth")
        {
            AssignEarthSpells();
        }
        else if(Element == "Air")
        {
            AssignAirSpells();
        }
        else if(Element == "Spirit")
        {
           AssignSpiritSpells();
        }
        
        foreach (Spells spell in Grimoire)
        {
            spell.AssignDamageValue();
            spell.AssignEnergyRequired();
        }
    }

    private void AssignWaterSpells()
    {
        Spells torrent = new Spells("Torrent Shot", "Water", 1, true);
        Spells mistVeil = new Spells("Mist Veil", "Water", 1, false);
        
        Grimoire.Add(torrent);
        Grimoire.Add(mistVeil);
    }

    private void AssignFireSpells()
    {
        Spells emberDart = new Spells("Ember Dart", "Fire", 1, true);
        Spells cinderCloak = new Spells("Cinder Cloak", "Fire", 1, false);

        Grimoire.Add(emberDart);
        Grimoire.Add(cinderCloak);
    }

    private void AssignEarthSpells()
    {
        Spells stoneShard = new Spells("Stone Shard", "Earth", 1, true);
        Spells earthenWard = new Spells("Earthen Ward", "Earth", 1, false);

        Grimoire.Add(stoneShard);
        Grimoire.Add(earthenWard);
    }

    private void AssignAirSpells()
    {
        Spells gustBlade = new Spells("Gust Blade", "Air", 1, true);
        Spells zephyrStep = new Spells("Zephyr's Step", "Air", 1, false);

        Grimoire.Add(gustBlade);
        Grimoire.Add(zephyrStep);
    }

    private void AssignSpiritSpells()
    {
        Spells soulTap = new Spells("Soul Tap", "Spirit", 1, true);
        Spells wardCLarity = new Spells("Ward of Clarity", "Spirit", 1, false);

        Grimoire.Add(soulTap);
        Grimoire.Add(wardCLarity);
    }
}
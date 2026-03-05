using System.Security.Cryptography.X509Certificates;
using FantasyRPG;

public static class PlayerUpgrades
{
    private static readonly Random Random = new Random();

    private static List<Spells> GenerateSpellOptions(Player player)
    {
        List<Spells> randomSpells = new List<Spells>();
        
        randomSpells = SpellLibrary.AllPlayerSpells.
            OrderBy(spells => Random.Next()).
            Where(s => !player.Grimoire.
            Any(knownSpell => knownSpell.Spell == s.Spell)).
            Take(3).
            ToList();

        return randomSpells;
    }

    private static double CalculateSpellCost(Player player, Spells spell)
    {
        double multiplier = spell.SpellElement == player.Element ? 1 : 1.45;
        double cost = 15 * multiplier;

        return cost;
    }
    public static Spells SelectNewSpell(Player player)
    {   
        List<Spells> randomSpells = GenerateSpellOptions(player);

        Console.WriteLine($"You have {player.Energy} available. Choose a new spell to learn. To select, enter the spell key:");

        foreach ((int index, Spells spell) in randomSpells.Index())
        {   
            double cost = CalculateSpellCost(player, spell);

            Console.WriteLine($"Key: {index}, Spell: {string.Join("", spell)} Cost: {cost} energy.");
        }

        int newSpellIndex = int.Parse(Console.ReadLine()!);
        Spells newSpell = randomSpells[newSpellIndex];

        return newSpell;
    }

    public static void LearnNewSpell(Player player)
    {
        Spells newSpell = SelectNewSpell(player);
        double spellCost = CalculateSpellCost(player, newSpell);

        bool energyAvailable = spellCost <= player.Energy ? true : false;

        if (energyAvailable)
        {   
            player.Grimoire.Add(newSpell);
            player.Energy -= spellCost;
            Console.WriteLine($"{string.Join(",", newSpell)} added to your Grimoire!");
        }
        else
        {
            Console.WriteLine($"Unable to add {newSpell} to Grimoire. Insufficient energy");
        }
    }
}
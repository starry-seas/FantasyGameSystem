using System.Runtime.InteropServices;

namespace FantasyRPG;

class Program
{
    static void Main(string[] args)
    {   
        ConfigureSpellsAndEnemies();
        Player player = ConfigurePlayer();

        Console.WriteLine($"Welcome {player.Name} of the {player.Element} coven. Here is your information: " + player.PlayerInformation());

    }

    static Player ConfigurePlayer()
    {
        Player user = new Player ("", "");
        user.AddBaseStats();
        user.AskPlayerName();
        user.SelectElement();
        user.CreateBaseGrimoire();

        return user;
    }

    static void ConfigureSpellsAndEnemies()
    {
        SpellLibrary.InitialisePlayerSpells();
        SpellLibrary.InitialiseEnemySpells();
        EnemyLibrary.CreateAllEnemies();
    }
}

        // if (chooseSpell == "Recover Health")
        // {
        //     if (player.PlayerStats[0] < 100)
        //     {
        //         player.PlayerStats[0] += 10;
        //         player.PlayerStats[1] -= player.Grimoire[0].EnergyRequired;
        //     }
            
        //     else if (player.PlayerStats[0] == 100)
        //     {
        //         Console.WriteLine("Health at maximum already, cannot use spell");
        //     }

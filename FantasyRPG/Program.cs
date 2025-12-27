using System.Runtime.InteropServices;

namespace FantasyRPG;

class Program
{
    static void Main(string[] args)
    {   
        GameArt.WizardHat();
        PressToStart();
        ConfigureSpellsAndEnemies();
        Player player = ConfigurePlayer();
        Enemies randomEnemy = GamePlay.GenerateRandomEnemy();

        Console.WriteLine($"Welcome {player.Name} of the {player.Element} coven. Here is your information: " + player.PlayerInformation());

        while(player.PlayerStats[0] > 0 && randomEnemy.Health > 0)
        {
            GamePlay.PlayerCastSpell(player, randomEnemy);
            GamePlay.EnemyTurn(randomEnemy, player);

            if(player.PlayerStats[0] == 0 || randomEnemy.Health == 0)
            {
                break;
            }
        }
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

    static void PressToStart()
    {
        Console.WriteLine("Press any key to start the game");
        Console.ReadKey(true);
       
    }
}

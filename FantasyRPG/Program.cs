using System.Runtime.InteropServices;

namespace FantasyRPG;
class Program
{
    static void Main(string[] args)
    {   
        // GameArt.WizardHat();
        PressToStart();
        ConfigureSpellsAndEnemies();
        Player player = ConfigurePlayer();
        Enemies randomEnemy = GamePlay.GenerateRandomEnemy();

        Console.WriteLine($"Welcome {player.Name} of the {player.Element} coven. Here is your information: " + player.PlayerInformation());

        while(player.Health > 0 && randomEnemy.Health > 0)
        {
            GamePlay.PlayerCastSpell(player, randomEnemy);
            GamePlay.EnemyTurn(player, randomEnemy);

            if (player.Health == 0)
            {
                player.XP += randomEnemy.DefeatXP/2.5;
                Console.WriteLine($"{player.Name} loses!");
                break;
            }
            else if (randomEnemy.Health == 0)
            {
                player.XP += randomEnemy.DefeatXP;
                Console.WriteLine($"{randomEnemy.Name} defeated!");
                break;
            }
        }
    }

    static Player ConfigurePlayer()
    {
        Player user = new Player ("", "");
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

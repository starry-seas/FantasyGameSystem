using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace FantasyRPG;
class Program
{
    static void Main(string[] args)
    {   
        PressToStart();
        ConfigureSpellsAndEnemies();
        Player player = ConfigurePlayer();
        
        Console.WriteLine($"Welcome {player.Name} of the {player.Element} coven. Here is your information: {player.PlayerInformation()}, Level: {player.Level}");

        Enemies enemy = BattleSystem.GenerateRandomEnemy();

        string battleWinner = Battle(player, enemy);

        if (battleWinner == player.Name)
        {
            Console.WriteLine($"Congratulations {player.Name}.");
        }
        else
        {
            Console.WriteLine($"You have been defeated by {enemy.Name}.");
        }

        Console.WriteLine($"XP = {player.XP} Energy {player.Energy} Level = {player.Level}");
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

    static string Battle(Player player, Enemies enemy)
    {
        string winner;

        while(player.Health > 0 && enemy.Health > 0)
        {
            BattleSystem.PlayerCastSpell(player, enemy);
            BattleSystem.EnemyTurn(player, enemy);

            if (player.Health == 0)
            {
                player.XP += enemy.DefeatXP/2.5;
                player.Energy = Math.Min(player.Energy + 30, 100);
                Console.WriteLine($"{player.Name} loses!");
                winner = enemy.Name;
                return winner;
            }
            else if (enemy.Health == 0)
            {
                player.XP += enemy.DefeatXP;
                player.Energy = 100;
                Console.WriteLine($"{enemy.Name} defeated!");
                winner = player.Name;
                return winner;
            }
        }

        return "Error, no winner found";
    }

    static void PostBattleOptions(Player player)
    {
        PlayerUpgrades.LearnNewSpell(player);
    }
}
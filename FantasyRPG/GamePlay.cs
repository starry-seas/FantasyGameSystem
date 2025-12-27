using System.CodeDom.Compiler;
using System.Threading.Tasks.Dataflow;
using FantasyRPG;
using Microsoft.VisualBasic;

public static class GamePlay
{
    public static Enemies GenerateRandomEnemy()
    {
        Random randomEnemy = new Random();
        int randomIndex = randomEnemy.Next(EnemyLibrary.AllEnemies.Count);
        var generatedEnemy = EnemyLibrary.AllEnemies[randomIndex];

        return generatedEnemy;
    }
    
    public static void PlayerCastSpell(Player player, Enemies randEnemy)
    {   

        Console.WriteLine($"Enemy: {randEnemy.Name}, Health = {randEnemy.Health}, Element = {randEnemy.Element}");

        Console.WriteLine($"{player.Name}'s turn.\n Select a spell from your Grimoire:\n {string.Join("", player.Grimoire)}");
        int playerChoice = int.Parse(Console.ReadLine()!);

        var spellChosen = player.Grimoire[playerChoice];
        int damage = spellChosen.DamageValue;
        int energy = spellChosen.EnergyRequired;
        string spell = spellChosen.Spell;

        player.PlayerStats[1] -= energy;
        randEnemy.Health -= damage;

        Console.WriteLine($"{player.Name} casts {spell}");
        if (spellChosen.CauseDamage)
        {
            Console.WriteLine($"{randEnemy.Name} takes {damage}!\n{randEnemy.Name} health = {randEnemy.Health}");
            Console.WriteLine($"{player.Name} health = {player.PlayerStats[0]}, energy = {player.PlayerStats[1]}");
        }
        else
        {
            Console.WriteLine($"{player.Name} health = {player.PlayerStats[0]}, energy = {player.PlayerStats[1]}");
        }  
    }

    public static void EnemyTurn(Enemies enemy, Player player)
    {   
        Random randomEnemySpell = new Random();
        int randomEnemyIndex = randomEnemySpell.Next(enemy.EnemyGrimoire.Count);
        var enemySpell = enemy.EnemyGrimoire[randomEnemyIndex];
        int enemyAttack = enemySpell.DamageValue;
        int enemyEnergy = enemySpell.EnergyRequired;

        enemy.Energy -= enemyEnergy;
        player.PlayerStats[0] -= enemyAttack;

        Console.WriteLine($"{enemy.Name} casts {enemySpell.Spell}! {player.Name} takes {enemyAttack} damage!");
        Console.WriteLine($"{player.Name} health = {player.PlayerStats[0]}, energy = {player.PlayerStats[1]}");
    }
}
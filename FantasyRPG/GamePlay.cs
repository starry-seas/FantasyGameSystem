using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using FantasyRPG;
using Microsoft.VisualBasic;

public static class GamePlay
{
    private static readonly Random Random = new Random();

    public static Enemies GenerateRandomEnemy()
    {
        int randomIndex = Random.Next(EnemyLibrary.AllEnemies.Count);
        var generatedEnemy = EnemyLibrary.AllEnemies[randomIndex];

        return generatedEnemy;
    }
    
    private static int PlayerSelectSpell(Player player, Enemies randEnemy)
    {   
        Console.WriteLine($"Enemy: {randEnemy.Name}, Health = {randEnemy.Health}, Element = {randEnemy.Element}");

        Console.WriteLine($"{player.Name}'s turn. Select a spell from your Grimoire. To select, enter the spell key:");
        foreach ((int index, Spells Item) in player.Grimoire.Index())
        {
            Console.WriteLine($"Key:{index}, Spell: {string.Join("", Item)}");
        }

        int playerChoice = int.Parse(Console.ReadLine()!);

        return playerChoice;
    }

    public static void PlayerCastSpell(Player player, Enemies enemy)
    {   
        var spellChosen = player.Grimoire[PlayerSelectSpell(player, enemy)];
        double damage = spellChosen.BaseDamage * GetElementMultiplier(spellChosen.SpellElement, enemy.Element);
        double energy = spellChosen.EnergyRequired;
        string spell = spellChosen.Spell;
        double spellXP = spellChosen.GainXP;

        player.Energy -= energy;
        player.Health += spellChosen.RestoreAmount;
        player.XP += spellXP;

        enemy.Health -= damage;

        Console.WriteLine($"{player.Name} casts {spell}");
        if (spellChosen.CauseDamage)
        {
            Console.WriteLine($"{enemy.Name} takes {damage}!\n{enemy.Name} health = {enemy.Health}");
            Console.WriteLine($"{player.Name} health = {player.Health}, energy = {player.Energy}");
        }
        else
        {
            Console.WriteLine($"{player.Name} health = {player.Health}, energy = {player.Energy}");
        }
    }  
    
    public static void EnemyTurn(Player player, Enemies enemy)
    {   
        int randomEnemyIndex = Random.Next(enemy.EnemyGrimoire.Count);
        var enemySpell = enemy.EnemyGrimoire[randomEnemyIndex];
        double enemyAttack = enemySpell.BaseDamage * GetElementMultiplier(enemySpell.SpellElement, player.Element);
        double enemyEnergy = enemySpell.EnergyRequired;

        enemy.Energy -= enemySpell.EnergyRequired;
        enemy.Health += enemySpell.RestoreAmount;
        player.Health -= enemyAttack;

        Console.WriteLine($"{enemy.Name} casts {enemySpell.Spell}! {player.Name} takes {enemyAttack} damage!");
        Console.WriteLine($"{player.Name} health = {player.Health}, energy = {player.Energy}");
    }

    private static double GetElementMultiplier(string attackElement, string defendantElement) => (attackElement, defendantElement) switch
    {   
        ("Water", "Water") => 0.5,
        ("Water", "Fire") => 2,
        ("Water", "Earth") => 1,
        ("Water", "Air") => 1,
        ("Water", "Spirit") => 0.25,

        ("Fire", "Water") => 0.25,
        ("Fire", "Fire") => 0.5,
        ("Fire", "Earth") => 2,
        ("Fire", "Air") => 1,
        ("Fire", "Spirit") => 1,
        
        ("Earth", "Water") => 1,
        ("Earth", "Fire") => 0.25,
        ("Earth", "Earth") => 0.5,
        ("Earth", "Air") => 1,
        ("Earth", "Spirit") => 1,

        ("Air", "Water") => 1,
        ("Air", "Fire") => 1,
        ("Air", "Earth") => 2,
        ("Air", "Air") => 0.5,
        ("Air", "Spirit") => 0.25,

        ("Spirit", "Water") => 2,
        ("Spirit", "Fire") => 1,
        ("Spirit", "Earth") => 0.25,
        ("Spirit", "Air") => 2,
        ("Spirit", "Spirit") => 0.5,
        _ => 1.0     
    };
}
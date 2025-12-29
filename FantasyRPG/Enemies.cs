using System.Runtime.CompilerServices;
using FantasyRPG;

public class Enemies
{
    public string Name {get; set;}
    public string Element {get; set;}
    public bool Boss {get; set;}
    public int Level {get; set;}
    public double Health {get; set;}
    public double Energy {get; set;}
    public double DefeatXP {get; set;} //XP gained when defeated
    public List<Spells> EnemyGrimoire {get; set;}

    public Enemies (string enemyName, string enemyElement, bool enemyType, int enemyLevel)
    {
        Name = enemyName;
        Element = enemyElement;
        Boss = enemyType;
        Level = enemyLevel;
        Health = (Level*15)+100;
        Energy = (Level*10)+100;
        DefeatXP = ((Level*3)/2)*10;
        EnemyGrimoire = new List<Spells>();
    }

    public void CreateEnemyGrimoire()
    {
        if (Boss)
        {
            EnemyGrimoire = SpellLibrary.AllEnemySpells.Where(s => s.SpellElement == Element).Take(5).ToList();
        }
        else if (Boss == false && Level > 2)
        {
            EnemyGrimoire = SpellLibrary.AllEnemySpells.Where(s => s.SpellElement == Element).Take(4).ToList();
        }
        else
        {
            EnemyGrimoire = SpellLibrary.AllEnemySpells.Where(s => s.SpellElement == Element && s.SpellLevel <3).Take(3).ToList();
        }

        foreach (Spells spell in EnemyGrimoire)
        {   
            if (Level >= 2 && spell.SpellLevel >= 2)
            spell.SpellLevel += Level;
        }
    }

    public void BossStats()
    {
        Health += 50;
        Energy += 50;
    }
}
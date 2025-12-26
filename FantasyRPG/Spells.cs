namespace FantasyRPG;

public class Spells
{
    public string Spell {get; set;}
    public string SpellElement {get; set;}
    public int SpellLevel {get; set;}
    public bool CauseDamage {get; set;}
    public int DamageValue {get; set;}
    public int EnergyRequired {get; set;}
    public bool BaseSpell {get; set;}

    public Spells(string spellName, string spellElementData, int spellLevelData, bool doesDamage, bool isBaseSpell)
    {
        Spell = spellName;
        SpellElement = spellElementData;
        SpellLevel = spellLevelData;
        CauseDamage = doesDamage;
        DamageValue = 0;
        EnergyRequired = 0;
        BaseSpell = isBaseSpell;
    }

    public void AssignDamageValue()
    {
        if (CauseDamage == true)
        {
            DamageValue += SpellLevel*5;
            
        }
        else
        {
            DamageValue = 0;
        }
    }

    public void AssignEnergyRequired()
    {
        EnergyRequired += SpellLevel*3;
    }

    public override string ToString()
    {   
        return $"Spell:{Spell}\n Element: {SpellElement}, Level {SpellLevel}, Damage: {DamageValue}, Energy Used: {EnergyRequired}\n";
    }

    
}
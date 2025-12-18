public class Spells
{
    public string Spell {get; set;}
    public string SpellElement {get; set;}
    public int SpellLevel {get; set;}
    public bool CauseDamage {get; set;}
    public int DamageValue {get; set;}
    public int EnergyRequired {get; set;}

    public Spells(string spellName, string spellElementData, int spellLevelData, bool doesDamage)
    {
        Spell = spellName;
        SpellElement = spellElementData;
        SpellLevel = spellLevelData;
        CauseDamage = doesDamage;
        DamageValue = 0;
        EnergyRequired = 0;
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
}
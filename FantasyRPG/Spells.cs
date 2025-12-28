namespace FantasyRPG;

public class Spells
{
    public string Spell {get; set;}
    public string SpellElement {get; set;}
    public int SpellLevel {get; set;}
    public bool CauseDamage {get; set;}
    public double BaseDamage {get; set;}
    public double EnergyRequired {get; set;}
    public bool BaseSpell {get; set;}
    public bool DoesRestore {get; set;}
    public double RestoreAmount {get; set;}
    public double GainXP {get; set;}
    public string Description {get; set;}

    public Spells(string spellName, string spellElementData, int spellLevelData, bool doesDamage, bool isBaseSpell, bool doesSpellRestore, string spellDescription)
    {
        Spell = spellName;
        SpellElement = spellElementData;
        SpellLevel = spellLevelData;
        CauseDamage = doesDamage;
        BaseDamage = AssignBaseDamage();
        EnergyRequired = AssignEnergyRequired();
        BaseSpell = isBaseSpell;
        DoesRestore = doesSpellRestore;
        RestoreAmount = AssignRestoreValues();
        GainXP = AssignXPGainedFromUse();
        Description = spellDescription;

    }

    private double AssignBaseDamage()
    {
        if (CauseDamage == true)
        {
            BaseDamage += SpellLevel*5;
        }
        else
        {
            BaseDamage = 0;
        }

        return BaseDamage;
    }

    private double AssignEnergyRequired()
    {
        EnergyRequired += SpellLevel*3;

        return EnergyRequired;
    }

    private double AssignRestoreValues()
    {
        if (DoesRestore == true)
        {
            RestoreAmount += SpellLevel*5;
        }
        else
        {
            RestoreAmount = 0;
        }

        return RestoreAmount;
    }

    private double AssignXPGainedFromUse()
    {
        GainXP = EnergyRequired*2.5/SpellLevel;
        return GainXP;
    }

    public override string ToString()
    {   
        return $"Spell:{Spell}\n Element: {SpellElement}, Level {SpellLevel}, Damage: {BaseDamage}, Energy Use: {EnergyRequired}\n";
    }
}
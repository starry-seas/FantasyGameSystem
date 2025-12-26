using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using FantasyRPG;

public static class SpellLibrary
{
    public static List<Spells> AllPlayerSpells = new List<Spells>();

    public static List<Spells> AllEnemySpells = new List<Spells>();

    public static void InitialisePlayerSpells()
    {   
        //water
        AllPlayerSpells.Add(new Spells("Water Heal", "Water", 1, false, true));
        AllPlayerSpells.Add(new Spells("Torrent Shot", "Water", 1, true, true));
        AllPlayerSpells.Add(new Spells("Mist Veil", "Water", 1, false, true));

        AllPlayerSpells.Add(new Spells("Tidal Surge", "Water", 2, true, false));     
        AllPlayerSpells.Add(new Spells("Frost Bind", "Water", 1, false, false));     
        AllPlayerSpells.Add(new Spells("Water Clone", "Water", 1, false, false));    
        AllPlayerSpells.Add(new Spells("Pressure Blast", "Water", 3, true, false));  
        AllPlayerSpells.Add(new Spells("Abyssal Trident", "Water", 2, true, false)); 
        AllPlayerSpells.Add(new Spells("Ice Shards", "Water", 1, true, false));      

        
        //fire
        AllPlayerSpells.Add(new Spells("Fire Heal", "Fire", 1, false, true));
        AllPlayerSpells.Add(new Spells("Ember Dart", "Fire", 1, true, true));
        AllPlayerSpells.Add(new Spells("Cinder Cloak", "Fire", 1, false, true));

        AllPlayerSpells.Add(new Spells("Wildfire", "Fire", 2, true, false));
        AllPlayerSpells.Add(new Spells("Searing Brand", "Fire", 1, true, false));
        AllPlayerSpells.Add(new Spells("Inner Flame", "Fire", 1, false, false));
        AllPlayerSpells.Add(new Spells("Flash Incineration", "Fire", 3, true, false));
        AllPlayerSpells.Add(new Spells("Blazing Barrier", "Fire", 2, false, false));
        AllPlayerSpells.Add(new Spells("Molten Strike", "Fire", 2, true, false));

        //earth
        AllPlayerSpells.Add(new Spells("Earth Heal", "Earth", 1, false, true));
        AllPlayerSpells.Add(new Spells("Stone Shard", "Earth", 1, true, true));
        AllPlayerSpells.Add(new Spells("Earthen Ward", "Earth", 1, false, true));

        AllPlayerSpells.Add(new Spells("Quake", "Earth", 3, true, false));
        AllPlayerSpells.Add(new Spells("Stone Grasp", "Earth", 1, false, false));
        AllPlayerSpells.Add(new Spells("Ironbark Skin", "Earth", 2, false, false));
        AllPlayerSpells.Add(new Spells("Landslide", "Earth", 3, true, false));
        AllPlayerSpells.Add(new Spells("Crystal Shrapnel", "Earth", 2, true, false));
        AllPlayerSpells.Add(new Spells("Petrify", "Earth", 1, true, false));

        
        //air
        AllPlayerSpells.Add(new Spells("Air Heal", "Air", 1, false, true));
        AllPlayerSpells.Add(new Spells("Gust Blade", "Air", 1, true, true));
        AllPlayerSpells.Add(new Spells("Zephyr's Step", "Air", 1, false, true));

        AllPlayerSpells.Add(new Spells("Cyclone", "Air", 2, true, false));
        AllPlayerSpells.Add(new Spells("Updraft", "Air", 1, false, false));
        AllPlayerSpells.Add(new Spells("Sonic Boom", "Air", 3, true, false));
        AllPlayerSpells.Add(new Spells("Wind Wall", "Air", 2, false, false));
        AllPlayerSpells.Add(new Spells("Chain Lightning", "Air", 2, true, false));
        AllPlayerSpells.Add(new Spells("Tailwind", "Air", 1, true, false));

        //spirit
        AllPlayerSpells.Add(new Spells("Spirit Heal", "Spirit", 1, false, true));
        AllPlayerSpells.Add(new Spells("Soul Tap", "Spirit", 1, true, true));
        AllPlayerSpells.Add(new Spells("Ward of Clarity", "Spirit", 1, false, true));

        AllPlayerSpells.Add(new Spells("Arcane Bolt", "Spirit", 1, true, false));
        AllPlayerSpells.Add(new Spells("Soul Siphon", "Spirit", 2, true, false));
        AllPlayerSpells.Add(new Spells("Mind Fog", "Spirit", 1, false, false));
        AllPlayerSpells.Add(new Spells("Astral Projection", "Spirit", 1, false, false));
        AllPlayerSpells.Add(new Spells("Spirit Lance", "Spirit", 3, true, false));
        AllPlayerSpells.Add(new Spells("Haunting Phantasm", "Spirit", 2, true, false));
        AllPlayerSpells.Add(new Spells("Fortify Soul", "Spirit", 2, true, false));


        //add damage and energy values and assign to sublist
        foreach (Spells spell in AllPlayerSpells)
        {
            spell.AssignDamageValue();
            spell.AssignEnergyRequired();
        } 
    }

    public static void InitialiseEnemySpells()
    {
        // Water Enemy Spells
        AllEnemySpells.Add(new Spells("Restorative Tide", "Water", 2, false, false));
        AllEnemySpells.Add(new Spells("Tsunami", "Water", 2, true, false));
        AllEnemySpells.Add(new Spells("Freezing Beam", "Water", 3, true, false));
        AllEnemySpells.Add(new Spells("Watery Grave", "Water", 3, true, false));
        AllEnemySpells.Add(new Spells("Drown", "Water", 1, true, false));

        // Fire Enemy Spells
        AllEnemySpells.Add(new Spells("Cauterizing Flame", "Fire", 2, false, false));
        AllEnemySpells.Add(new Spells("Inferno", "Fire", 3, true, false));
        AllEnemySpells.Add(new Spells("Magma Burst", "Fire", 2, true, false));
        AllEnemySpells.Add(new Spells("Pyroclasm", "Fire", 3, true, false));
        AllEnemySpells.Add(new Spells("Smother", "Fire", 1, true, false));

        // Earth Enemy Spells
        AllEnemySpells.Add(new Spells("Regenerative Soil", "Earth", 2, false, false));
        AllEnemySpells.Add(new Spells("Boulder Crash", "Earth", 2, true, false));
        AllEnemySpells.Add(new Spells("Seismic Slam", "Earth", 3, true, false));
        AllEnemySpells.Add(new Spells("Javelin Rock", "Earth", 2, true, false));
        AllEnemySpells.Add(new Spells("Entomb", "Earth", 1, true, false)); 

        // Air Enemy Spells
        AllEnemySpells.Add(new Spells("Revitalizing Gust", "Air", 2, false, false));
        AllEnemySpells.Add(new Spells("Thunderclap", "Air", 3, true, false));
        AllEnemySpells.Add(new Spells("Tornado", "Air", 2, true, false));
        AllEnemySpells.Add(new Spells("Slicing Winds", "Air", 2, true, false));
        AllEnemySpells.Add(new Spells("Vacuum", "Air", 1, false, false)); 

        // Spirit Enemy Spells
        AllEnemySpells.Add(new Spells("Leech Essence", "Spirit", 2, false, false)); 
        AllEnemySpells.Add(new Spells("Soul Scour", "Spirit", 3, true, false));
        AllEnemySpells.Add(new Spells("Necrotic Blast", "Spirit", 2, true, false));
        AllEnemySpells.Add(new Spells("Mind Spike", "Spirit", 2, true, false));
        AllEnemySpells.Add(new Spells("Terrify", "Spirit", 1, true, false));

        foreach (Spells spell in AllEnemySpells)
        {
            spell.AssignDamageValue();
            spell.AssignEnergyRequired();
        }   
        
    }
}
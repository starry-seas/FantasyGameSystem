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
        AllPlayerSpells.Add(new Spells("Purifying Tide", "Water", 1, false, true, true, "Restores health."));
        AllPlayerSpells.Add(new Spells("Torrent Shot", "Water", 1, true, true, false, "A basic water attack."));
        AllPlayerSpells.Add(new Spells("Tidal Surge", "Water", 2, true, false, false, "A moderate water attack."));
        AllPlayerSpells.Add(new Spells("Pressure Blast", "Water", 3, true, false, false, "A powerful water attack."));

        //fire
        AllPlayerSpells.Add(new Spells("Phoenix Mend", "Fire", 1, false, true, true, "Restores health."));
        AllPlayerSpells.Add(new Spells("Ember Dart", "Fire", 1, true, true, false, "A basic fire attack."));
        AllPlayerSpells.Add(new Spells("Wildfire", "Fire", 2, true, false, false, "A moderate fire attack."));
        AllPlayerSpells.Add(new Spells("Flash Incineration", "Fire", 3, true, false, false, "A powerful fire attack."));

        //earth
        AllPlayerSpells.Add(new Spells("Stone Salve", "Earth", 1, false, true, true, "Restores health."));
        AllPlayerSpells.Add(new Spells("Stone Shard", "Earth", 1, true, true, false, "A basic earth attack."));
        AllPlayerSpells.Add(new Spells("Crystal Shrapnel", "Earth", 2, true, false, false, "A moderate earth attack."));
        AllPlayerSpells.Add(new Spells("Landslide", "Earth", 3, true, false, false, "A powerful earth attack."));

        //air
        AllPlayerSpells.Add(new Spells("Zephyr's Balm", "Air", 1, false, true, true, "Restores health."));
        AllPlayerSpells.Add(new Spells("Gust Blade", "Air", 1, true, true, false, "A basic air attack."));
        AllPlayerSpells.Add(new Spells("Cyclone", "Air", 2, true, false, false, "A moderate air attack."));
        AllPlayerSpells.Add(new Spells("Sonic Boom", "Air", 3, true, false, false, "A powerful air attack."));

        //spirit
        AllPlayerSpells.Add(new Spells("Soul Mending", "Spirit", 1, false, true, true, "Restores health."));
        AllPlayerSpells.Add(new Spells("Soul Tap", "Spirit", 1, true, true, false, "A basic spirit attack."));
        AllPlayerSpells.Add(new Spells("Spirit Lance", "Spirit", 2, true, false, false, "A moderate spirit attack."));
        AllPlayerSpells.Add(new Spells("Haunting Phantasm", "Spirit", 3, true, false, false, "A powerful spirit attack."));
    }

    public static void InitialiseEnemySpells()
    {
        // Water Enemy Spells
        AllEnemySpells.Add(new Spells("Restorative Tide", "Water", 1, false, false, true, "Restores health."));
        AllEnemySpells.Add(new Spells("Tsunami", "Water", 1, true, false, false, "A basic water attack."));
        AllEnemySpells.Add(new Spells("Watery Grave", "Water", 2, true, false, false, "A moderate water attack."));
        AllEnemySpells.Add(new Spells("Freezing Beam", "Water", 3, true, false, false, "A powerful water attack."));

        // Fire Enemy Spells
        AllEnemySpells.Add(new Spells("Cauterizing Flame", "Fire", 1, false, false, true, "Restores health."));
        AllEnemySpells.Add(new Spells("Magma Burst", "Fire", 1, true, false, false, "A basic fire attack."));
        AllEnemySpells.Add(new Spells("Pyroclasm", "Fire", 2, true, false, false, "A moderate fire attack."));
        AllEnemySpells.Add(new Spells("Inferno", "Fire", 3, true, false, false, "A powerful fire attack."));

        // Earth Enemy Spells
        AllEnemySpells.Add(new Spells("Regenerative Soil", "Earth", 1, false, false, true, "Restores health."));
        AllEnemySpells.Add(new Spells("Boulder Crash", "Earth", 1, true, false, false, "A basic earth attack."));
        AllEnemySpells.Add(new Spells("Javelin Rock", "Earth", 2, true, false, false, "A moderate earth attack."));
        AllEnemySpells.Add(new Spells("Seismic Slam", "Earth", 3, true, false, false, "A powerful earth attack."));

        // Air Enemy Spells
        AllEnemySpells.Add(new Spells("Revitalizing Gust", "Air", 1, false, false, true, "Restores health."));
        AllEnemySpells.Add(new Spells("Slicing Winds", "Air", 1, true, false, false, "A basic air attack."));
        AllEnemySpells.Add(new Spells("Tornado", "Air", 2, true, false, false, "A moderate air attack."));
        AllEnemySpells.Add(new Spells("Thunderclap", "Air", 3, true, false, false, "A powerful air attack."));

        // Spirit Enemy Spells
        AllEnemySpells.Add(new Spells("Leech Essence", "Spirit", 1, false, false, true, "Restores health."));
        AllEnemySpells.Add(new Spells("Terrify", "Spirit", 1, true, false, false, "A basic spirit attack."));
        AllEnemySpells.Add(new Spells("Necrotic Blast", "Spirit", 2, true, false, false, "A moderate spirit attack."));
        AllEnemySpells.Add(new Spells("Soul Scour", "Spirit", 3, true, false, false, "A powerful spirit attack."));
    }
}
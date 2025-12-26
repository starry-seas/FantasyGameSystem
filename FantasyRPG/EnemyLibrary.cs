using FantasyRPG;

public static class EnemyLibrary
{
    public static List<Enemies>AllEnemies = new List<Enemies>();

    public static void CreateAllEnemies()
    {
        // === Water Enemies ===
        AllEnemies.Add(new Enemies("Water Sprite", "Water", false, 1));
        AllEnemies.Add(new Enemies("River Nymph", "Water", false, 2));
        AllEnemies.Add(new Enemies("Swamp Lurker", "Water", false, 3));
        AllEnemies.Add(new Enemies("Tidal Warrior", "Water", false, 4));
        AllEnemies.Add(new Enemies("Leviathan", "Water", true, 5));

        // === Fire Enemies ===
        AllEnemies.Add(new Enemies("Emberling", "Fire", false, 1));
        AllEnemies.Add(new Enemies("Flame Dasher", "Fire", false, 2));
        AllEnemies.Add(new Enemies("Hellhound", "Fire", false, 3));
        AllEnemies.Add(new Enemies("Magma Golem", "Fire", false, 4));
        AllEnemies.Add(new Enemies("Ifrit", "Fire", true, 5));

        // === Earth Enemies ===
        AllEnemies.Add(new Enemies("Rock Crab", "Earth", false, 1));
        AllEnemies.Add(new Enemies("Tunnel Worm", "Earth", false, 2));
        AllEnemies.Add(new Enemies("Stone Guardian", "Earth", false, 3));
        AllEnemies.Add(new Enemies("Basilisk", "Earth", false, 4));
        AllEnemies.Add(new Enemies("Mountain Colossus", "Earth", true, 5));

        // === Air Enemies ===
        AllEnemies.Add(new Enemies("Gustling", "Air", false, 1));
        AllEnemies.Add(new Enemies("Storm Crow", "Air", false, 2));
        AllEnemies.Add(new Enemies("Thunderbird", "Air", false, 3));
        AllEnemies.Add(new Enemies("Tempest Weaver", "Air", false, 4));
        AllEnemies.Add(new Enemies("Sky Titan", "Air", true, 5));

        // === Spirit Enemies ===
        AllEnemies.Add(new Enemies("Wisp", "Spirit", false, 1));
        AllEnemies.Add(new Enemies("Shade", "Spirit", false, 2));
        AllEnemies.Add(new Enemies("Haunt", "Spirit", false, 3));
        AllEnemies.Add(new Enemies("Soul Reaver", "Spirit", false, 4));
        AllEnemies.Add(new Enemies("Spectral Lord", "Spirit", true, 5));

        foreach (Enemies enemy in AllEnemies)
        {
            enemy.CreateEnemyGrimoire();
        }
    }
}
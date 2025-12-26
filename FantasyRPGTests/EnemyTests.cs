using FantasyRPG;

public class EnemyTests
{
    [Fact]
    public void Constructor_InitialiseAllEnemyProperties()
    {
        Enemies testBoss = new Enemies ("Leviathan", "Water", true, 5);

        Assert.Equal("Leviathan", testBoss.Name);
        Assert.Equal("Water", testBoss.Element);
        Assert.True(testBoss.Boss);
        Assert.Equal(5, testBoss.Level);
        Assert.Equal(175, testBoss.Health);
        Assert.Equal(150, testBoss.Energy);
        Assert.Equal(70, testBoss.DefeatXP);
        Assert.Equal(0, testBoss.EnemyGrimoire.Count());
    }

    [Fact]
    public void CreateEnemyGrimoire_ShouldAllocateBasedOnLevelAndElement()
    {   
        SpellLibrary.InitialiseEnemySpells();
        Enemies boss = new Enemies ("Leviathan", "Fire", true, 5);
        boss.CreateEnemyGrimoire();

        Assert.Equal(5, boss.EnemyGrimoire.Count());
        Assert.Equal("Smother", boss.EnemyGrimoire[4].Spell);
        Assert.Equal(5, boss.EnemyGrimoire[4].DamageValue);
        Assert.Equal(3, boss.EnemyGrimoire[4].EnergyRequired);

        
        Enemies midLevel = new Enemies ("Imp", "Spirit", false, 3);
        midLevel.CreateEnemyGrimoire();
        Assert.Equal(4, midLevel.EnemyGrimoire.Count());

        Enemies lowLevel = new Enemies ("Troll", "Fire", false, 1);
        lowLevel.CreateEnemyGrimoire();
        Assert.Equal(3, lowLevel.EnemyGrimoire.Count());
    }
}
using System.Net.Http.Headers;
using System.Reflection;

public class PlayerTests
{
    [Fact]
    public void Constructor_ShouldInitialiseAllPlayerProperties()
    {
        Player afifa = new Player("Afifa", "Water");

        Assert.Equal("Afifa", afifa.Name);
        Assert.Equal("Water", afifa.Element);
        Assert.Empty(afifa.Grimoire);
        Assert.Empty(afifa.PlayerStats);
    }

    [Fact]
    public void AddBaseStats_AddToStatsList()
    {
        Player bobby = new Player("Bobby", "Air");
        bobby.AddBaseStats();

        Assert.Equal(100, bobby.PlayerStats[0]);
        Assert.Equal(100, bobby.PlayerStats[1]);
        Assert.Equal(2, bobby.PlayerStats.Count);

    }

    [Fact]
    public void CreateGrimoire_AddBaseSpellsDependingOnElement()
    {
        Player harry = new Player("Harry", "Water");

        harry.CreateBaseGrimoire();
        Assert.Equal(5, harry.Grimoire.Count);
        Assert.Equal("Torrent Shot", harry.Grimoire[3].Spell);
        Assert.Equal(5, harry.Grimoire[3].DamageValue);
        Assert.Equal(3, harry.Grimoire[3].EnergyRequired);
    }
}
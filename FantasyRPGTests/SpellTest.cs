using System.Reflection;
using System.Reflection.Metadata;
using FantasyRPG;

namespace FantasyRPGTests;

public class SpellTest
{
    [Fact]
    public void Constructor_ShouldInitialiseAllProperties()
    {
      Spells heal = new Spells("Recover Health", "Spirit", 1, false, true);

      Assert.Equal("Recover Health", heal.Spell);
      Assert.Equal("Spirit", heal.SpellElement);
      Assert.False(heal.CauseDamage);
      Assert.Equal(1, heal.SpellLevel);
      Assert.Equal(0, heal.DamageValue);
      Assert.Equal(0, heal.EnergyRequired);
    }

    [Fact]
    public void AssignDamageValue_CheckIsCorrect()
    {
        Spells fireBlast = new Spells("Fire Blast", "Fire", 1, true, true);

        fireBlast.AssignDamageValue();

        Assert.Equal(5, fireBlast.DamageValue);
    }

    [Fact]
    public void AssignEnergyRequired_CheckIfCorrect()
    {
        Spells waterBlast = new Spells("Water Blast", "Water", 2, true, true);

        waterBlast.AssignEnergyRequired();

        Assert.Equal(6, waterBlast.EnergyRequired);
    }
}

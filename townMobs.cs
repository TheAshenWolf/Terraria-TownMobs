using Terraria;
using Terraria.ModLoader;

namespace townMobs
{
  /// <summary>
  /// Main class of the mod
  /// </summary>
  public class TownMobs : ModSystem
  {
    /// <inheritdoc />
    public override void PreUpdateEntities()
    {
      base.PreUpdateEntities();
      
      foreach (Player player in Main.player)
      {
        player.townNPCs = 0;
      }
    }
  }
  

  /// <summary>
  /// Only used for debugging purposes (this mod's changes are not really visible by default)
  /// </summary>
  public class TownMobsPlayer : ModPlayer
  {
    /// <inheritdoc />
    public override void OnEnterWorld()
    {
      base.OnEnterWorld();
      Main.NewText("Town mobs loaded!", 150, 250, 150);
    }
  }
}
using Terraria;
using Terraria.ModLoader;

namespace townMobs
{
  public class TownMobs : Mod
  {
    public override void PreUpdateEntities()
    {
      base.PreUpdateEntities();

      foreach (Player player in Main.player)
      {
        player.townNPCs = 0;
      }
    }
  }
}
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace RainOverhaul
{
    public class GetGlobalItem:GlobalItem
    {
        //List of vanilla tiles and wands that will let the player know the tile will not protect entities from the rain.
        public override void ModifyTooltips(Terraria.Item item, List<TooltipLine> tooltips)
        {
            if (item.type==ItemID.DirtBlock||item.type==ItemID.Wood||item.type==ItemID.ClayBlock||item.type==ItemID.Spike||
                item.type==ItemID.Cobweb||item.type==ItemID.SandBlock||item.type==ItemID.Glass||item.type==ItemID.AshBlock||
                item.type==ItemID.MudBlock||item.type==ItemID.EbonsandBlock||item.type==ItemID.PearlsandBlock||item.type==ItemID.SiltBlock||
                item.type==ItemID.InactiveStoneBlock||item.type==ItemID.CandyCaneBlock||item.type==ItemID.GreenCandyCaneBlock||item.type==ItemID.SnowBlock||
                item.type==ItemID.SnowBrick||item.type==ItemID.Ebonwood||item.type==ItemID.RichMahogany||item.type==ItemID.Pearlwood||
                item.type==ItemID.ThinIce||item.type==ItemID.PineTreeBlock||item.type==ItemID.Cactus||item.type==ItemID.Cloud||
                item.type==ItemID.GlowingMushroom||item.type==ItemID.LivingWoodWand||item.type==ItemID.LeafWand||item.type==ItemID.SlimeBlock||
                item.type==ItemID.BoneWand||item.type==ItemID.FleshBlock||item.type==ItemID.RainCloud||item.type==ItemID.SlushBlock||
                item.type==ItemID.HiveWand||item.type==ItemID.HoneyBlock||item.type==ItemID.CrispyHoneyBlock||item.type==ItemID.WoodenSpike||
                item.type==ItemID.CrimsandBlock||item.type==ItemID.Pumpkin||item.type==ItemID.Hay||item.type==ItemID.SpookyWood||
                item.type==ItemID.Cog||item.type==ItemID.DynastyWood||item.type==ItemID.CoralstoneBlock||item.type==ItemID.BorealWood||
                item.type==ItemID.PalmWood||item.type==ItemID.WaterfallBlock||item.type==ItemID.LavafallBlock||item.type==ItemID.ConfettiBlock||
                item.type==ItemID.ConfettiBlockBlack||item.type==ItemID.LivingFireBlock||item.type==ItemID.LivingCursedFireBlock||item.type==ItemID.LivingDemonFireBlock||
                item.type==ItemID.LivingIchorBlock||item.type==ItemID.LivingUltrabrightFireBlock||item.type==ItemID.HoneyfallBlock||item.type==ItemID.SmokeBlock||
                item.type==ItemID.PinkSlimeBlock||item.type==ItemID.Bubble||item.type==ItemID.LivingMahoganyWand||item.type==ItemID.LivingMahoganyLeafWand||
                item.type==ItemID.DesertFossil||item.type==ItemID.ConveyorBeltRight||item.type==ItemID.ConveyorBeltLeft||item.type==ItemID.SillyBalloonPink||
                item.type==ItemID.SillyBalloonPurple||item.type==ItemID.SillyBalloonGreen||item.type==ItemID.SandFallBlock||item.type==ItemID.SnowFallBlock||
                item.type==ItemID.LesionBlock||item.type==ItemID.CrackedBlueBrick||item.type==ItemID.CrackedGreenBrick||item.type==ItemID.CrackedPinkBrick||
                item.type==ItemID.ShellPileBlock||item.type==ItemID.SpiderBlock||item.type==ItemID.GoldStarryGlassBlock||item.type==ItemID.BlueStarryGlassBlock||
                item.type==ItemID.Grate||item.type==ItemID.BambooBlock||item.type==ItemID.LargeBambooBlock||item.type==ItemID.AshWood||item.type==ItemID.ReefBlock||
                item.type==ItemID.PoopBlock)
            {
                tooltips.Add(new TooltipLine(Mod, "Terraria", "[c/627599:This block] [c/536381:will not] [c/627599:protect from] [c/536381:the rain]"));
            }
        }
    }
}
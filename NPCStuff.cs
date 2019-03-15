using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterObtainables
{
	public class NPCStuff : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Truffle)
			{
				shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
				shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 15);
				nextSlot++;
			}
		}

		public override void SetupTravelShop(int[] shop, ref int nextSlot)
		{
			shop[nextSlot++] = ItemID.FishermansGuide;
		}
	}
}

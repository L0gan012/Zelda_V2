using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class HUDConstants
    {
        //Mini HUD
        public static readonly float HUDWidth = 256;
        public static readonly float HUDHeight = 56;

        public static readonly float MiniMapRoomWidth = 8;
        public static readonly float MiniMapRoomHeight = 4;

        public static readonly Vector2 LevelTextPosition = new Vector2(18, 4);
        public static readonly Vector2 LifeTextPosition = new Vector2(8, -24);
        public static readonly Vector2 MiniMapPosition = new Vector2(20, 20);
        public static readonly Vector2 UserMiniMapPosition = new Vector2(2, 0);
        public static readonly Vector2 TriforcePiecePosition = new Vector2(42, 4);

        public static readonly float HeartWidth = 8;
        public static readonly Vector2 HealthBarLocation = new Vector2(190, 40);

        public static readonly Vector2 RupeePosition = new Vector2(88, 16);
        public static readonly Vector2 RupeeCountPosition = RupeePosition + new Vector2(8, 0);
        public static readonly Vector2 KeyPosition = new Vector2(88, 32);
        public static readonly Vector2 KeyCountPosition = KeyPosition + new Vector2(8, 0);
        public static readonly Vector2 BombPosition = new Vector2(88, 40);
        public static readonly Vector2 BombCountPosition = BombPosition + new Vector2(8, 0);
        public static readonly Vector2 BSlotPosition = new Vector2(115, 16);
        public static readonly Vector2 ASlotPosition = new Vector2(139, 16);

        //Pause HUD
        public static readonly float PauseHUDWidth = 256;
        public static readonly float PauseHUDHeight = 176;

        public static readonly Vector2 SelectedItemBoxPosition = new Vector2(59, 43);
        public static readonly Vector2 InventoryBoxPosition = new Vector2(123, 43);
        public static readonly Vector2 HasMapPosition = new Vector2(48, 112);
        public static readonly Vector2 HasCompassPosition = new Vector2(44, 152);

        public static readonly float MapRoomWidth = 8;
        public static readonly float MapRoomHeight = 8;
        public static readonly Vector2 MapPosition = new Vector2(96, 88);
        public static readonly Vector2 MapRoomPosition = MapPosition + new Vector2(40, 24);
        public static readonly Vector2 UserMapPosition = MapRoomPosition + new Vector2(2, 3);

        //Might be weird
        public static readonly float ItemWidth = 24;
        public static readonly float ItemHeight = 16;
        public static readonly Vector2 ItemSelectorStartPosition = new Vector2(128, 48);
        public static readonly float ItemSelectorYLimit = ItemSelectorStartPosition.Y + 2 * ItemHeight;
        public static readonly float ItemSelectorXLimit = ItemSelectorStartPosition.X + 4 * ItemWidth;
        public static readonly Vector2 ItemSelectorOffset = new Vector2(4, 0);

        public static readonly Vector2 SelectedItemPosition = new Vector2(SelectedItemBoxPosition.X + 9, SelectedItemBoxPosition.Y + 5);
        public static readonly Vector2 PrimaryItemPosition = ASlotPosition + new Vector2(5, 8);
        public static readonly Vector2 SecondaryItemPosition = BSlotPosition + new Vector2(5, 8);

        public static readonly Vector2 BoomerangInventoryPosition = new Vector2(132, 48);
        public static readonly Vector2 BombInventoryPosition = new Vector2(156, 48);
        public static readonly Vector2 BowAndArrowInventoryPosition = new Vector2(176, 48);
        public static readonly Vector2 CandleInventoryPosition = new Vector2(204, 48);
        public static readonly Vector2 LadderInventoryPosition = new Vector2(176, 24);
    }
}

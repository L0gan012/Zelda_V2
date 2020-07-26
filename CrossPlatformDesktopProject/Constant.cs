using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class Constant
    {
        public static readonly Vector2 LinkStartPosition = new Vector2(360, 544);
        public static readonly Vector2 BlockStartPosition = new Vector2(200, 150);
        public static readonly Vector2 ItemStartPosition = new Vector2(400, 150);
        public static readonly Vector2 EnemyStartPosition = new Vector2(600, 200);
        public static readonly Vector2 BackGroundStartPosition = new Vector2(0, 0);

        public static readonly float OriginalNesWidth = 256;
        public static readonly float OriginalNesHeight = 232;

        public static float DisplayScaleX = 3;
        public static float DisplayScaleY = 3;

        public static readonly int MaxAquamentusXRange = 50;
        public static readonly int MinAquamentusXRange = 15;
        public static readonly float AquamentusSpeed = 0.4f;
        public static readonly float AquamentusDamageAmount = 2;
        public static readonly float AquamentusHP = 10;
        public static readonly float AqumentusProjectileSpeed = 3;
        public static readonly int AquamentusProjectileTime =  150;
        public static readonly float AquamentusProjectileDamageAmount = .5f;
        public static readonly int AquamentusMouthOpenTime = 40;
        public static readonly float AquamentusProjectileAngle = 20;

        public static readonly float DodongoDamageAmount = 1;
        public static readonly float DodongoHP = 5;

        public static readonly float GelSpeed = 1;
        public static readonly int GelMovementTimer = 20;
        public static readonly float GelDamageAmount = .5f;
        public static readonly float GelHP = 1;

        public static readonly float GoriyaSpeed = 2;
        public static readonly int GoriyaMovementTimer = 40;
        public static readonly float GoriyaDamageAmount = .5f;
        public static readonly float GoriyaHP = 3;

        public static readonly float KeeseSpeed = 2;
        public static readonly int KeeseMovementTimer = 15;
        public static readonly float KeeseDamageAmount = .5f;
        public static readonly float KeeseHP = 1;

        public static readonly float OldManDamageAmount = 0;
        public static readonly float OldManHP = 1;

        public static readonly float SpikeCrossCollisionSpeed = 5;
        public static readonly float SpikeCrossRetractionSpeed = 2.5f;
        public static readonly float SpikeCrossDamageAmount = .5f;
        public static readonly float SpikeCrossHP = 1;

        public static readonly float StalfosSpeed = 1.5f;
        public static readonly int StalfosMovementTimer = 80;
        public static readonly float StalfosDamageAmount = .5f;
        public static readonly float StalfosHP = 1;

        public static readonly float WallmasterSpeed = 1;
        public static readonly int WallmasterAppearanceDistance = 30;
        public static readonly float WallmasterDamageAmount = .5f;
        public static readonly float WallmasterHP = 1;

        public static readonly float ZolDamageAmount = .5f;
        public static readonly float ZolHP = 1;

        public static readonly int FramesPerSecond = 60;

        public static readonly float LinkStartHP = 3;

        //Animation Speed setting
        public static readonly int TicksPerFrameWalk = 8;
        public static readonly int TicksPerFrameAttackSword = 8;
        public static readonly int TicksPerFrameSwordProjectiles = 1;
        public static readonly int TicksPerFrameEnemyDeath = 10;
        public static readonly int TicksPerFrameHalfHeart = 20;
        public static readonly int TicksPerFrameSwordBeamCollision = 1;

        public static readonly int EffectSwordBeamCollisionTimer = 15;

        //Movement Speed settings
        public static readonly int LinkMovementSpeed = 4;
        public static readonly int LinkKnockback = 32;
        public static readonly int LinkKnockbackSpeed = 2;

        public static readonly int EnemyKnockback = 32;
        public static readonly int NPCKnockbackSpeed = 2;

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int LinkHeight = 16;
        public static readonly int LinkWidth = 16;

        public static readonly int RooomDisplayHeight = 534;
        public static readonly int RooomDisplayWidth = 771;

        public static readonly int ScreenWidth = Game1.Instance.GraphicsDevice.Viewport.Width;
        public static readonly int ScreenHeight = Game1.Instance.GraphicsDevice.Viewport.Height;
        public static readonly Vector2 CenterOfScreen = new Vector2(ScreenWidth / 2, ScreenHeight / 2);

        public static readonly float HUDWidth = 256 * DisplayScaleX;
        public static readonly float HUDHeight = 56 * DisplayScaleY;

        public static readonly float PauseHUDWidth = 256 * DisplayScaleX;
        public static readonly float PauseHUDHeight = 176 * DisplayScaleY;

        //Block info
        public static readonly float DungeonWallWidth = 32 * DisplayScaleX;
        public static readonly float DungeonWallHeight = 32 * DisplayScaleY;

        public static readonly float DungeonFloorWidth = ScreenWidth - (2 * DungeonWallWidth);
        public static readonly float DungeonFloorHeight = ScreenHeight - (2 * DungeonWallHeight) - HUDHeight;

        public static readonly int DungeonGridWidth = 6;
        public static readonly int DungeonGridHeight = 6;

        public static readonly int VerticalSwordHeight = 16;
        public static readonly int VerticalSwordWidth = 8;
        public static readonly int HorizontalSwordHeight = 8;
        public static readonly int HorizontalSwordWidth = 16;

        //Link Damaged time
        public static readonly int DamagedTime = 25;

        //random number generator
        public static readonly Random RNG = new Random();

        public static readonly int BlockKnockback = 50;
        public static readonly int BlockMovementSpeed = 2;

        //Item info
        public static readonly int ItemOffset = 36;
        public static readonly int ItemKnockback = 50;
        public static readonly int ItemKnockbackSpeed = 3;

        public static readonly int BombTimer = 100;
        public static readonly int BombExplosionTime = 30;
        public static readonly float BombExplosionDamageAmount = .5f;

        public static readonly int FlameDistance = 100;
        public static readonly int FlameSpeed = 2;
        public static readonly float FlameDamageAmount = .5f;

        public static readonly int BoomerangDistance = 300;
        public static readonly int BoomerangSpeed = 5;
        public static readonly float BoomerangDamageAmount = .5f;

        public static readonly int ArrowSpeed = 6;
        public static readonly float ArrowDamageAmount = .5f;

        public static readonly int SwordBeamSpeed = 6;
        public static readonly int SwordBeamCollisionSpeed = 1;
        public static readonly float SwordDamageAmount = .5f;


        public static readonly int ItemDropChance = 20;
        public static readonly int AquamentusFireChance = 5000;

        //HUD Info
        public static readonly float MapRoomWidth = 8 * DisplayScaleX;
        public static readonly float MapRoomHeight = 8 * DisplayScaleY;
        public static readonly Vector2 MapPosition = new Vector2(96 * DisplayScaleX, 88 * DisplayScaleY);
        public static readonly Vector2 MapRoomPosition = MapPosition + new Vector2(40 * DisplayScaleX, 24 * DisplayScaleY);
        public static readonly Vector2 UserMapPosition = MapRoomPosition + new Vector2(2 * DisplayScaleX, 3 * DisplayScaleY);

        public static readonly float MiniMapRoomWidth = 8 * DisplayScaleX;
        public static readonly float MiniMapRoomHeight = 4 * DisplayScaleY;

        public static readonly Vector2 MiniMapPosition = new Vector2(20 * DisplayScaleX, 20 * DisplayScaleY);
        public static readonly Vector2 UserMiniMapPosition = new Vector2(2 * DisplayScaleX, 0);
        public static readonly Vector2 TriforcePiecePosition = new Vector2(42 * DisplayScaleX, 4 * DisplayScaleY);

        public static readonly float HeartWidth = 8 * DisplayScaleX;
        public static readonly Vector2 HealthBarLocation = new Vector2(190 * DisplayScaleX, 40 * DisplayScaleY);

        public static readonly Vector2 RupeePosition = new Vector2(88 * DisplayScaleX, 16 * DisplayScaleY);
        public static readonly Vector2 RupeeCountPosition = RupeePosition + new Vector2(8 * DisplayScaleX, 0);
        public static readonly Vector2 KeyPosition = new Vector2(88 * DisplayScaleX, 32 * DisplayScaleY);
        public static readonly Vector2 KeyCountPosition = KeyPosition + new Vector2(8 * DisplayScaleX, 0);
        public static readonly Vector2 BombPosition = new Vector2(88 * DisplayScaleX, 40 * DisplayScaleY);
        public static readonly Vector2 BombCountPosition = BombPosition + new Vector2(8 * DisplayScaleX, 0);
        public static readonly Vector2 BSlotPosition = new Vector2(115 * DisplayScaleX, 16 * DisplayScaleY);
        public static readonly Vector2 ASlotPosition = new Vector2(139 * DisplayScaleX, 16 * DisplayScaleY);

        public static readonly Vector2 InventoryPanelLocation = new Vector2(0, 0 * 88 * DisplayScaleY);
        public static readonly Vector2 DungeonPanelLocation = new Vector2(0, 1 * 88 * DisplayScaleY);
        public static readonly Vector2 HUDPanelLocation = new Vector2(0, 2 * 88 * DisplayScaleY);

        public static readonly Vector2 SelectedItemBoxPosition = new Vector2(59 * DisplayScaleX, 43 * DisplayScaleY);
        public static readonly Vector2 InventoryBoxPosition = new Vector2(123 * DisplayScaleX, 43 * DisplayScaleY);
        public static readonly Vector2 HasMapPosition = new Vector2(48 * DisplayScaleX, 112 * DisplayScaleY);
        public static readonly Vector2 HasCompassPosition = new Vector2(44 * DisplayScaleX, 152 * DisplayScaleY);

        public static readonly float ItemWidth = 24 * DisplayScaleX;
        public static readonly float ItemHeight = 16 * DisplayScaleY;
        public static readonly Vector2 ItemSelectorStartPosition = new Vector2(130 * DisplayScaleX, 48 * DisplayScaleY);
        public static readonly float ItemSelectorYLimit = ItemSelectorStartPosition.Y + 2 * ItemHeight;
        public static readonly float ItemSelectorXLimit = ItemSelectorStartPosition.X + 4 * ItemWidth;
        public static readonly Vector2 ItemSelectorOffset = new Vector2(9, 5);

        public static readonly Vector2 SelectedItemPosition = new Vector2(SelectedItemBoxPosition.X + 9 * DisplayScaleX, SelectedItemBoxPosition.Y + 5 * DisplayScaleY);
        public static readonly Vector2 PrimaryItemPosition = ASlotPosition + new Vector2(5 * DisplayScaleX, 8 * DisplayScaleY);
        public static readonly Vector2 SecondaryItemPosition = BSlotPosition + new Vector2(5 * DisplayScaleX, 8 * DisplayScaleY);

        public static readonly Vector2 ItemCacheStartPosition = new Vector2(130 * DisplayScaleX, 48 * DisplayScaleY);
        public static readonly Vector2 BoomerangInventoryPosition = new Vector2(ItemCacheStartPosition.X, ItemCacheStartPosition.Y);
        public static readonly Vector2 BombInventoryPosition = new Vector2(BoomerangInventoryPosition.X + ItemWidth, BoomerangInventoryPosition.Y);
        public static readonly Vector2 BowAndArrowInventoryPosition = new Vector2(BombInventoryPosition.X + ItemWidth, BombInventoryPosition.Y);
        public static readonly Vector2 CandleInventoryPosition = new Vector2(BowAndArrowInventoryPosition.X + ItemWidth, BowAndArrowInventoryPosition.Y);

        public static readonly Vector2 LadderInventoryPosition = new Vector2(BowAndArrowInventoryPosition.X + ItemWidth * 3, BowAndArrowInventoryPosition.Y - ItemHeight);

        public static readonly Vector2 UpOverBombedPosition = new Vector2(112 * DisplayScaleX, 0 * DisplayScaleY + HUDHeight);
        public static readonly Vector2 LeftOverBombedPosition = new Vector2(0 * DisplayScaleX, 72 * DisplayScaleY + HUDHeight);
        public static readonly Vector2 DownOverBombedPosition = new Vector2(112 * DisplayScaleX, 156 * DisplayScaleY + HUDHeight);
        public static readonly Vector2 DownOverWallPosition = new Vector2(112 * DisplayScaleX, 156 * DisplayScaleY + HUDHeight);
        public static readonly Vector2 RightOverBombedPosition = new Vector2(239 * DisplayScaleX, 72 * DisplayScaleY + HUDHeight);

        //Settings info
        public static readonly Color FairySelectorColor = Color.White;
        public static readonly float FairyXOffset = 16 * DisplayScaleX;
        public static readonly float FairyYOffset = 1 * DisplayScaleY;

        public static readonly Vector2 GameStartOptionPosition = new Vector2(90 * DisplayScaleX, 210 * DisplayScaleY);

        public static readonly Vector2 TitlePosition = new Vector2(90 * DisplayScaleX, 16 * DisplayScaleY);
        public static readonly Vector2 Option1Position = new Vector2(50 * DisplayScaleX, 48 * DisplayScaleY);
        public static readonly Vector2 Option2Position = new Vector2(50 * DisplayScaleX, 64 * DisplayScaleY);
        public static readonly Vector2 Option3Position = new Vector2(50 * DisplayScaleX, 80 * DisplayScaleY);
        public static readonly Vector2 Option4Position = new Vector2(50 * DisplayScaleX, 96 * DisplayScaleY);
        public static readonly Vector2 Option5Position = new Vector2(50 * DisplayScaleX, 112 * DisplayScaleY);
        public static readonly Vector2 Option6Position = new Vector2(50 * DisplayScaleX, 128 * DisplayScaleY);
        public static readonly Vector2 Option7Position = new Vector2(50 * DisplayScaleX, 144 * DisplayScaleY);

        public static readonly Vector2 TabInstructionPosition = new Vector2(90 * DisplayScaleX, 184 * DisplayScaleY);
        public static readonly Vector2 SpaceInstructionPosition = new Vector2(64 * DisplayScaleX, 200 * DisplayScaleY);
        public static readonly Vector2 GoBackInstructionPosition = new Vector2(90 * DisplayScaleX, 216 * DisplayScaleY);
    }
}


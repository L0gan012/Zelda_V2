using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class Constant
    {
        public static readonly Vector2 LinkStartPosition = new Vector2(200, 300);
        public static readonly Vector2 BlockStartPosition = new Vector2(200, 150);
        public static readonly Vector2 ItemStartPosition = new Vector2(400, 150);
        public static readonly Vector2 EnemyStartPosition = new Vector2(600, 200);
        public static readonly Vector2 BackGroundStartPosition = new Vector2(0, 0);

        public static readonly int MaxAquamentusXRange = 40;
        public static readonly int MinAquamentusXRange = 10;
        public static readonly float AquamentusSpeed = 0.5f;
        public static readonly float AquamentusDamageAmount = 2;
        public static readonly float AquamentusHP = 10;
        public static readonly float AqumentusProjectileSpeed = .5f;
        public static readonly int AquamentusProjectileTime =  300;
        public static readonly float AquamentusProjectileDamageAmount = .5f;
        public static readonly int AquamentusMouthOpenTime = 40;

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
        public static readonly int TicksPerFrameEnemyDeath = 1;
        public static readonly int TicksPerHalfHeart = 20;

        //Movement Speed settings
        public static readonly int LinkMovementSpeed = 4;
        public static readonly int LinkKnockback = 32;
        public static readonly int LinkKnockbackSpeed = 2;

        public static readonly int EnemyKnockback = 32;
        public static readonly int NPCKnockbackSpeed = 2;

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int DisplayScaleX = 3;  // Constant.ScreenWidth / 16;
        public static readonly int DisplayScaleY = 3;  // Constant.ScreenHeight / 14;
        public static readonly int LinkHeight = 16;
        public static readonly int LinkWidth = 16;

        public static readonly int RooomDisplayHeight = 534;
        public static readonly int RooomDisplayWidth = 771;

        public static readonly int ScreenWidth = Game1.Instance.GraphicsDevice.Viewport.Width;
        public static readonly int ScreenHeight = Game1.Instance.GraphicsDevice.Viewport.Height;

        public static readonly int HUDWidth = ScreenWidth;
        public static readonly int HUDHeight = ScreenHeight / 4;

        public static readonly int DungeonFloorWidth = ScreenWidth - (2 * DungeonWallWidth);
        public static readonly int DungeonFloorHeight = ScreenHeight - (2 * DungeonWallHeight);

        public static readonly int VerticalSwordHeight = 16;
        public static readonly int VerticalSwordWidth = 8;
        public static readonly int HorizontalSwordHeight = 8;
        public static readonly int HorizontalSwordWidth = 16;

        //Link Damaged time
        public static readonly int DamagedTime = 25;

        //random number generator
        public static readonly Random RNG = new Random();

        //Block info
        public static readonly int DungeonWallWidth = 62;
        public static readonly int DungeonWallHeight = 64;

        public static readonly int BlockKnockback = 50;
        public static readonly int BlockMovementSpeed = 2;

        //Item info
        public static readonly int ItemOffset = 36;
        public static readonly int ItemKnockback = 50;
        public static readonly int ItemKnockbackSpeed = 3;

        public static readonly int BombTimer = 50;

        public static readonly int FlameDistance = 100;
        public static readonly int FlameSpeed = 2;
        public static readonly float FlameDamageAmount = .5f;

        public static readonly int BoomerangDistance = 300;
        public static readonly int BoomerangSpeed = 5;

        public static readonly int ArrowSpeed = 6;

        public static readonly int SwordBeamSpeed = 6;

        public static readonly int ItemDropChance = 20;
        public static readonly int AquamentusFireChance = 5000;

    }
}


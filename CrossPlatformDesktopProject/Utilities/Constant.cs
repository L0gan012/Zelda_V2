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

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int LinkHeight = 16;
        public static readonly int LinkWidth = 16;

        public static readonly int RooomDisplayHeight = 534;
        public static readonly int RooomDisplayWidth = 771;

        public static readonly int ScreenWidth = Game1.Instance.GraphicsDevice.Viewport.Width;
        public static readonly int ScreenHeight = Game1.Instance.GraphicsDevice.Viewport.Height;
        public static readonly Vector2 CenterOfScreen = new Vector2(ScreenWidth / 2, ScreenHeight / 2);

        //Block info
        public static readonly float DungeonWallWidth = 32 * DisplayScaleX;
        public static readonly float DungeonWallHeight = 32 * DisplayScaleY;

        public static readonly float DungeonFloorWidth = ScreenWidth - (2 * DungeonWallWidth);
        public static readonly float DungeonFloorHeight = ScreenHeight - (2 * DungeonWallHeight) - HUDConstants.HUDHeight;

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

        public static readonly Vector2 UpOverBombedPosition = new Vector2(112 * DisplayScaleX, 0 * DisplayScaleY + HUDConstants.HUDHeight);
        public static readonly Vector2 LeftOverBombedPosition = new Vector2(0 * DisplayScaleX, 72 * DisplayScaleY + HUDConstants.HUDHeight);
        public static readonly Vector2 DownOverBombedPosition = new Vector2(112 * DisplayScaleX, 156 * DisplayScaleY + HUDConstants.HUDHeight);
        public static readonly Vector2 DownOverWallPosition = new Vector2(112 * DisplayScaleX, 156 * DisplayScaleY + HUDConstants.HUDHeight);
        public static readonly Vector2 RightOverBombedPosition = new Vector2(239 * DisplayScaleX, 72 * DisplayScaleY + HUDConstants.HUDHeight);
    }
}


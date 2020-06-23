using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class Constant
    {
        public static readonly Vector2 LinkStartPosition = new Vector2(200, 300);
        public static readonly Vector2 BlockStartPosition = new Vector2(200, 150);
        public static readonly Vector2 ItemStartPosition = new Vector2(400, 150);
        public static readonly Vector2 EnemyStartPosition = new Vector2(600, 175);

        public static readonly int MaxAquamentusXRange = 40;
        public static readonly int MinAquamentusXRange = 10;
        public static readonly float AquamentusSpeed = 0.5f;

        public static readonly int FramesPerSecond = 60;

        //Animation Speed setting
        public static readonly int TicksPerFrameWalk = 8;
        public static readonly int TicksPerFrameAttackSword = 4;
        public static readonly int TicksPerFrameSwordProjectiles = 1;

        //Movement Speed settings
        public static readonly int LinkMovementSpeed = 5;
        public static readonly int SwordBeamSpeed = 8;

        //One game grid square is 16*16 pixels.  DisplayScales multiply output size
        public static readonly int DisplayScaleX = 3;  // Constant.ScreenWidth / 16;
        public static readonly int DisplayScaleY = 3;  // Constant.ScreenHeight / 14;
        public static readonly int LinkHeight = 16;
        public static readonly int LinkWidth = 16;

        public static readonly int ScreenWidth = 1280;  //(int)Game1.windowWidth;
        public static readonly int ScreenHeight = 720; //(int)Game1.windowHeight;

        public static readonly int VerticalSwordHeight = 16;
        public static readonly int VerticalSwordWidth = 8;
        public static readonly int HorizontalSwordHeight = 8;
        public static readonly int HorizontalSwordWidth = 16;

        //Link Damaged time
        public static readonly int DamagedTime = 25;

        //random number generator
        public static readonly Random RNG = new Random();

        //Block info
        public static readonly int DungeonWallWidth = 50;
        public static readonly int DungeonWallHeight = 50;

        //Item info
        public static readonly int ItemOffset = 30;

        public static readonly int BombTimer = 50;

        public static readonly int FlameDistance = 100;
        public static readonly int FlameSpeed = 2;

        public static readonly int BoomerangDistance = 300;
        public static readonly int BoomerangSpeed = 5;

        public static readonly int ArrowSpeed = 6;
        public enum ArrowType { wooden, silver }
    }
}


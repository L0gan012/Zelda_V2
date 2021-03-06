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

        public static float DisplayScaleX = Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth;
        public static float DisplayScaleY = Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight;

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

        public static int DungeonGridWidth = 6;
        public static int DungeonGridHeight = 6;

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

        public static readonly Vector2 UpOverBombedPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (0 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftOverBombedPosition = new Vector2(0 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownOverBombedPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (156 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));     
        public static readonly Vector2 RightOverBombedPosition = new Vector2(239 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));

        public static readonly Vector2 UpOverBombedPositionNative = new Vector2(112, 0);
        public static readonly Vector2 LeftOverBombedPositionNative = new Vector2(0, 72);
        public static readonly Vector2 DownOverBombedPositionNative = new Vector2(112, 156);
        public static readonly Vector2 RightOverBombedPositionNative = new Vector2(236, 72);

        public static readonly Vector2 UpDoorPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (0 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownDoorPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (144 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftDoorPosition = new Vector2(0 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightDoorPosition = new Vector2(224 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
    
        public static readonly Vector2 UpDoorPositionNoHud = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 0 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownDoorPositionNoHud = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 144 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftDoorPositionNoHud = new Vector2(0 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 72 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightDoorPositionNoHud = new Vector2(224 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 72 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));

        public static readonly Vector2 UpDoorPositionNative = new Vector2(112, 0);
        public static readonly Vector2 DownDoorPositionNative = new Vector2(112, 144);
        public static readonly Vector2 LeftDoorPositionNative = new Vector2(0, 72);
        public static readonly Vector2 RightDoorPositionNative = new Vector2(224, 72);

        public static readonly Vector2 UpOverDoorPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (0 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftOverDoorPosition = new Vector2(0 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownOverDoorPosition = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (159 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightOverDoorPosition = new Vector2(239 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (72 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
   
        public static readonly Vector2 UpOverDoorPositionNoHud = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 0 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftOverDoorPositionNoHud = new Vector2(0 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 72 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownOverDoorPositionNoHud = new Vector2(112 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 159 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightOverDoorPositionNoHud = new Vector2(239 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 72 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));

        public static readonly Vector2 UpOverDoorPositionNative = new Vector2(112, 0);
        public static readonly Vector2 LeftOverDoorPositionNative = new Vector2(0, 72);
        public static readonly Vector2 DownOverDoorPositionNative = new Vector2(112, 159);
        public static readonly Vector2 RightOverDoorPositionNative = new Vector2(239, 72);

        public static readonly Vector2 UpDoorStopPosition = new Vector2(120 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (16 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftDoorStopPosition = new Vector2(16 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (80 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightDoorStopPosition = new Vector2(224 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (80 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownDoorStopPosition = new Vector2(120 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (144 + HUDConstants.HUDHeight) * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));

        public static readonly Vector2 UpDoorStopPositionNative = new Vector2(120 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 16 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 LeftDoorStopPositionNative = new Vector2(16 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 80 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 RightDoorStopPositionNative = new Vector2(224 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 80 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));
        public static readonly Vector2 DownDoorStopPositionNative = new Vector2(120 * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, 144 * (Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight));



        //Keys
        public static readonly Vector2 ItemDropPositionRoom2 = new Vector2(131 * DisplayScaleX, (49 + HUDConstants.HUDHeight) * (DisplayScaleY));
        public static readonly Vector2 ItemDropPositionRoom8 = new Vector2(115 * DisplayScaleX, (67 + HUDConstants.HUDHeight) * (DisplayScaleY));

        //Boomerang
        public static readonly Vector2 ItemDropPositionRoom15 = new Vector2(147 * DisplayScaleX, (52 + HUDConstants.HUDHeight) * (DisplayScaleY));

        //Keys
        public static readonly Vector2 ItemDropPositionRoom16 = new Vector2(166 * DisplayScaleX, (128 + HUDConstants.HUDHeight) * (DisplayScaleY));
        public static readonly Vector2 ItemDropPositionRoom20 = new Vector2(145 * DisplayScaleX, (50 + HUDConstants.HUDHeight) * (DisplayScaleY));
        public static readonly Vector2 ItemDropPositionRoom31 = new Vector2(163 * DisplayScaleX, (126 + HUDConstants.HUDHeight) * (DisplayScaleY));
        public static readonly Vector2 ItemDropPositionRoom33 = new Vector2(87 * DisplayScaleX, (71 + HUDConstants.HUDHeight) * (DisplayScaleY));




    }
}


﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
using Sprint2;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        public GameObjects objects { get; set; }
        private List<IController> controllers;
        private static Game1 instance = new Game1();


        public ILink Link { get; set; }

        public List<IPlayer> playerObjectList;

        public CollisionDetector collisionDetector;

        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;

        public static Game1 Instance
        {
            get
            {
                return instance;
            }
        }


        private Game1()
        {
            graphics = new GraphicsDeviceManager(this); 
            graphics.IsFullScreen = false;
            //graphics.PreferredBackBufferHeight = Constant.RooomDisplayHeight;
            //graphics.PreferredBackBufferWidth = Constant.RooomDisplayWidth;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            objects = new GameObjects();

            controllers = new List<IController>();
            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            Link = new Link();
            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            ICommand reset = new ResetCommand();
            reset.Execute();

            collisionDetector = new CollisionDetector();

            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            foreach (IController controller in controllers)
            {
                controller.RegisterCommand();
            }
            objects.LoadGameObjects();
            objects.UpdateRoom();

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            Link.Update();
            objects.Update();


            playerObjectList = new List<IPlayer>();

            playerObjectList.Add(Link);

            collisionDetector.Update(playerObjectList,
                RoomClass.CurrentRoomChars,
                RoomClass.CurrentRoomProjectiles,
                RoomClass.CurrentRoomBlocks,
                RoomClass.CurrentRoomItems,
                RoomClass.CurrentRoomUsableItems);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            objects.Draw(spriteBatch);
            Link.Draw(spriteBatch);


            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}

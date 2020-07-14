using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Level
    {
        /*
        public Game game;
        public GameObjects objects { get; set; }
        private List<IController> controllers;

        public ILink Link { get; set; }

        public List<IPlayer> playerObjectList;

        public CollisionDetector collisionDetector;

        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;


        public Level(Game1 game)
        {
            this.game = game;
        }

        public void Initialize()
        {
            objects = new GameObjects();

            controllers = new List<IController>();
            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            Link = new Link();
            LinkSpriteFactory.Instance.LoadAllTextures(game.Content);

            ICommand reset = new ResetCommand();
            reset.Execute();

            collisionDetector = new CollisionDetector(); objects = new GameObjects();

            controllers = new List<IController>();
            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            Link = new Link();
            LinkSpriteFactory.Instance.LoadAllTextures(game.Content);

            ICommand reset = new ResetCommand();
            reset.Execute();

            collisionDetector = new CollisionDetector();
        }

        public void Update()
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

        }
        */

    }
}

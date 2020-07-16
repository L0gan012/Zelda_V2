using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
	public class NPCSpriteFactory
	{
		private Dictionary<string, Texture2D> npcSpriteContent;
		private static NPCSpriteFactory instance = new NPCSpriteFactory();

		public static NPCSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private NPCSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			npcSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/NPCTextures");
		}

		public ISprite CreateNPCOldMan()
        {
			return new SpriteNPCOldMan(npcSpriteContent["NPColdManIdle"]);
		}

	}
}

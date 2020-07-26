using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
	public class LinkSpriteFactory
    {
		private Texture2D linkSpritesheet;
		private static LinkSpriteFactory instance = new LinkSpriteFactory();

		public static LinkSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private LinkSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			linkSpritesheet = content.Load<Texture2D>("TextureSheets/LinkTextures/LinkSpriteSheet");
		}

		public ISprite CreateLinkIdleLeftSprite()
		{
			return new SpriteLinkIdleLeft(linkSpritesheet);
		}

		public ISprite CreateLinkIdleRightSprite()
		{
			return new SpriteLinkIdleRight(linkSpritesheet);
		}

		public ISprite CreateLinkIdleUpSprite()
		{
			return new SpriteLinkIdleUp(linkSpritesheet);
		}

		public ISprite CreateLinkIdleDownSprite()
		{
			return new SpriteLinkIdleDown(linkSpritesheet);
		}

		public ISprite CreateMovingLeftLinkSprite()
		{
			return new SpriteLinkWalkLeft(linkSpritesheet);
		}

		public ISprite CreateMovingRightLinkSprite()
		{
			return new SpriteLinkWalkRight(linkSpritesheet);
		}

		public ISprite CreateMovingUpLinkSprite()
		{
			return new SpriteLinkWalkUp(linkSpritesheet);
		}

		public ISprite CreateMovingDownLinkSprite()
		{
			return new SpriteLinkWalkDown(linkSpritesheet);
		}

		public ISprite CreateUsingItemLeftLinkSprite()
		{
			return new SpriteLinkUseItemLeft(linkSpritesheet);
		}

		public ISprite CreateUsingItemRightLinkSprite()
		{
			return new SpriteLinkUseItemRight(linkSpritesheet);
		}

		public ISprite CreateUsingItemUpLinkSprite()
		{
			return new SpriteLinkUseItemUp(linkSpritesheet);
		}

		public ISprite CreateUsingItemDownLinkSprite()
		{
			return new SpriteLinkUseItemDown(linkSpritesheet);
		}

		public ISprite CreateAttackingLeftLinkSprite()
		{
			return new SpriteLinkAttackLeft(linkSpritesheet);
		}

		public ISprite CreateAttackingRightLinkSprite()
		{
			return new SpriteLinkAttackRight(linkSpritesheet);
		}

		public ISprite CreateAttackingUpLinkSprite()
		{
			return new SpriteLinkAttackUp(linkSpritesheet);
		}

		public ISprite CreateAttackingDownLinkSprite()
		{
			return new SpriteLinkAttackDown(linkSpritesheet);
		}

		public ISprite CreateGetItemLinkSprite()
		{
			return new SpriteLinkGetItem(linkSpritesheet);
		}
	}
}

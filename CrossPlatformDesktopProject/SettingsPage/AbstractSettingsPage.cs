using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public abstract class AbstractSettingsPage: ISettingsPage
    {

        protected List<IOption> Options { get; } = new List<IOption>();
        protected int OptionsIndex { get; set; } = 0;

        protected Rectangle rect { get; set; } = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
        protected Texture2D background { get; set; }

        protected ISprite Fairy { get; set; } = ItemsSpriteFactory.Instance.CreateSpriteFairy();
        protected Vector2 FairyPosition
        {
            get
            {
                //just in case Options is empty
                Vector2 result = Constant.CenterOfScreen;
                if(Options.Count > 0)
                {
                    Vector2 tempOptionPosition = Options[OptionsIndex].Position;
                    result = new Vector2(tempOptionPosition.X - Constant.FairyXOffset, tempOptionPosition.Y - Constant.FairyYOffset);
                }
                return result;
            }
        }

        protected String Title { get; set; } = "";


        public void selectOption()
        {
            if (Options.Count > 0)
            {
                Options[OptionsIndex].Select();
            }
        }

        public void cycleOption()
        {
            OptionsIndex++;
            if (OptionsIndex >= Options.Count)
            {
                OptionsIndex = 0;
            }
        }

        public void Update()
        {
            foreach (IOption option in Options)
            {
                option.Update();
            }
            Fairy.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, rect, Color.White);

            spriteBatch.DrawString(spriteFont, Title, Constant.TitlePosition, Color.White);

            foreach (IOption option in Options)
            {
                option.Draw(spriteBatch, spriteFont);
            }

            Fairy.Draw(spriteBatch, Constant.FairySelectorColor, FairyPosition);

            spriteBatch.DrawString(spriteFont, "tab - Up & Down", Constant.TabInstructionPosition, Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", Constant.SpaceInstructionPosition, Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", Constant.GoBackInstructionPosition, Color.White);
        }
    }
}

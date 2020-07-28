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
                    result = new Vector2(tempOptionPosition.X - SettingsConstants.FairyOffset.X * Constant.DisplayScaleX, tempOptionPosition.Y - SettingsConstants.FairyOffset.Y * Constant.DisplayScaleY);
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
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.White);

            spriteBatch.DrawString(spriteFont, Title, new Vector2(SettingsConstants.TitlePosition.X * Constant.DisplayScaleX, SettingsConstants.TitlePosition.Y * Constant.DisplayScaleY), Color.White);

            foreach (IOption option in Options)
            {
                option.Draw(spriteBatch, spriteFont);
            }

            Fairy.Draw(spriteBatch, SettingsConstants.FairySelectorColor, FairyPosition);

            spriteBatch.DrawString(spriteFont, "tab - Up & Down", new Vector2(SettingsConstants.TabInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.TabInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", new Vector2(SettingsConstants.SpaceInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.SpaceInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", new Vector2(SettingsConstants.GoBackInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.GoBackInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
        }
    }
}

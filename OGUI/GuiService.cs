using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using OGUI.Windows;
using Microsoft.Xna.Framework.Graphics;
using OGUI.Input;

namespace OGUI
{
    public class GuiService : DrawableGameComponent
    {
        List<GuiWindow> windows;
        public static Texture2D Pixel;
        public static SpriteFont font;
        public SpriteBatch sb;

        public GuiService(Game game, SpriteBatch sb)
            :base(game)
        {
            this.sb = sb;
            windows = new List<GuiWindow>();
        }

        public void Add(GuiWindow window)
        {
            windows.Add(window);
        }

        public void Remove(GuiWindow window)
        {
            windows.Remove(window);
        }

        protected override void LoadContent()
        {
            Pixel = new Texture2D(Game.GraphicsDevice, 1, 1);
            Pixel.SetData<Color>(new Color[] { Color.White });
            font = Game.Content.Load<SpriteFont>(@"fonts/font");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            GuiInput.I.Update();
            foreach (GuiWindow w in windows)
            {
                w.Update(gameTime);
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            sb.Begin();
            foreach (GuiWindow w in windows)
            {
                w.Draw(gameTime);
            }
            sb.End();
            base.Draw(gameTime);
        }
    }
}

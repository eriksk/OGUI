using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using OGUI.Drawing;
using Microsoft.Xna.Framework;

namespace OGUI.Components
{
    public class Button : Component
    {
        public event OnClickedEvent OnClicked;
        public delegate void OnClickedEvent();
        private Vector2 textOrigin;

        public Button(string name)
        {
            this.name = name;
            textOrigin = GuiService.font.MeasureString(name) / 2f;
            area = new Rectangle(0, 0, (int)(textOrigin.X * 2f) + 10, (int)(textOrigin.Y * 2f) + 2);
        }

        public override void Draw(SpriteBatch sb, Point position)
        {
            sb.Draw(GuiService.Pixel, new Rectangle(position.X + area.X, position.Y + area.X, area.Width, area.Height), Color.Black * 0.4f);
            sb.DrawBorder(GuiService.Pixel, new Rectangle(position.X + area.X, position.Y + area.X, area.Width, area.Height), Color.Black);
            sb.DrawString(GuiService.font, name, new Vector2(position.X + area.Center.X, position.Y + area.Center.Y), Color.White, 0f, textOrigin, 1f, SpriteEffects.None, 1f);
        }
    }
}

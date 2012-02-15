using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace OGUI.Drawing
{
    public static class DrawHelper
    {
        public static void DrawBorder(this SpriteBatch sb, Texture2D pixel, Rectangle r, Color color)
        {
            sb.Draw(pixel, new Rectangle(r.X, r.Y, r.Width, 1), color); //top
            sb.Draw(pixel, new Rectangle(r.X, r.Bottom, r.Width + 1, 1), color); //bottom           
            sb.Draw(pixel, new Rectangle(r.X, r.Y, 1, r.Height), color); //left
            sb.Draw(pixel, new Rectangle(r.Right, r.Y, 1, r.Height), color); //right
        }
    }
}

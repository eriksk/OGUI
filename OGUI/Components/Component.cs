using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OGUI.Components
{
    public abstract class Component
    {
        public string name;
        public Rectangle area;

        public void Move(int x, int y)
        {
            area.X = x;
            area.Y = y;
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch sb, Point position)
        {

        }
    }
}

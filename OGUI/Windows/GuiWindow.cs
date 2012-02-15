using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using OGUI.Drawing;
using OGUI.Input;
using Microsoft.Xna.Framework.Input;
using OGUI.Components;

namespace OGUI.Windows
{
    public class GuiWindow
    {
        private GuiService gui;
        public Rectangle area;
        public List<Component> components;

        public GuiWindow(GuiService gui)
        {
            this.gui = gui;
            area = new Rectangle(200, 200, 200, 200);
            components = new List<Component>();
        }

        public GuiWindow Load(ContentManager content)
        {
            components.Add(new Button("X"));
            return this;
        }

        public void Close()
        {
            gui.Remove(this);
        }

        public void Update(GameTime gameTime)
        {
            if (GuiInput.I.m.LeftButton == ButtonState.Pressed)
            {
                if (new Rectangle(area.X, area.Y, area.Width, 20).Contains(GuiInput.I.m.X, GuiInput.I.m.Y))
                {
                    area.X -= GuiInput.I.om.X - GuiInput.I.m.X;
                    area.Y -= GuiInput.I.om.Y - GuiInput.I.m.Y;
                }
            }

            foreach (var c in components)
            {
                c.Update();
            }
        }

        public void Draw(GameTime gameTime)
        {
            gui.sb.Draw(GuiService.Pixel, area, Color.Black * 0.4f);
            gui.sb.Draw(GuiService.Pixel, new Rectangle(area.X, area.Y, area.Width, 20), Color.Black * 0.4f);
            
            gui.sb.DrawBorder(GuiService.Pixel, new Rectangle(area.X, area.Y, area.Width, 20), Color.Black);
            gui.sb.DrawBorder(GuiService.Pixel, area, Color.Black);

            foreach (var c in components)
            {
                c.Draw(gui.sb, area.Location);
            }
        }
    }
}

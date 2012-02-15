using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OGUI.Input
{
    public class GuiInput
    {
        private GuiInput()
        {
        }
        private static GuiInput instance = new GuiInput();
        public static GuiInput I
        {
            get
            {
                return instance;
            }
        }

        public bool KeyClicked(Keys k)
        {
            return oldkey.IsKeyUp(k) && key.IsKeyDown(k);
        }

        public bool LMC()
        {
            return om.LeftButton == ButtonState.Released && m.LeftButton == ButtonState.Pressed;
        }

        public MouseState om, m;
        public KeyboardState oldkey, key;
        public void Update()
        {
            oldkey = key;
            om = m;
            key = Keyboard.GetState();
            m = Mouse.GetState();
        }
    }
}

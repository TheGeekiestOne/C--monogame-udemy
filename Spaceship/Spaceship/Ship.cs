using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    class Ship
    {

        //public Vector2 postition = new Vector2(100, 100);
        public int speed = 180;
        static public Vector2 defaultPos = new Vector2(640, 360);
        public Vector2 postition = defaultPos;

        public void shipUpdate(GameTime gameTime, Controller gameController) //void doesnt return anything
        {
            //postition.Y++;
            KeyboardState kState = Keyboard.GetState();
            //double dt = gameTime.ElapsedGameTime.TotalSeconds;
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (gameController.inGame)
            {
                if (kState.IsKeyDown(Keys.Right) && postition.X < 1280)
                {
                    postition.X += speed * dt; // ++ =>move at 1 pixel at a time 

                }

                if (kState.IsKeyDown(Keys.Left) && postition.X > 0)
                {
                    postition.X -= speed * dt;
                }

                if (kState.IsKeyDown(Keys.Down) && postition.Y < 720)
                {
                    postition.Y += speed * dt;
                }

                if (kState.IsKeyDown(Keys.Up) && postition.Y > 0)
                {
                    postition.Y -= speed * dt;
                }
            }
        }

    }
}

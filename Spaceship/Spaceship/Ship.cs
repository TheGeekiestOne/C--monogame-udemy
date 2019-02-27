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

        public Vector2 postition = new Vector2(100, 100);
        public int speed = 3;

        public void shipUpdate(GameTime gameTime) //void doesnt return anything
        {
            //postition.Y++;
            KeyboardState kState = Keyboard.GetState();
            //double dt = gameTime.ElapsedGameTime.TotalSeconds;
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right))
            {
                postition.X += speed * dt; //move at 1 pixel at a time 

            }

            if (kState.IsKeyDown(Keys.Left))
            {
                postition.X -= speed;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                postition.Y += speed;
            }

            if (kState.IsKeyDown(Keys.Up))
            {
                postition.Y -= speed;
            }
        }

    }
}

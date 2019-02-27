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
    class Asteroid
    {

        public Vector2 postion = new Vector2(600, 600);
        public int speed = 220;
        public int radius = 59;

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            postion.X -= speed * dt;
        }
    }
}

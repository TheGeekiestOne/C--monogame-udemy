﻿using System;
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

        public Vector2 postion;// = new Vector2(600, 300);
        public int speed;
        public int radius = 59;
        public bool offscreen = false;

        static Random rand = new Random();

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;

            //Random rand = new Random();
            postion = new Vector2(1280 + radius, rand.Next(0, 721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            postion.X -= speed * dt;
        }
    }
}

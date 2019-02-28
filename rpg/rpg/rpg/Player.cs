using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{ 

    class Player
    {
        private Vector2 position = new Vector2(100, 100);
        private int health = 3;
        private int speed = 200;
        private Dir direction = Dir.Down;

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }

        }

        public void setX(float newX)
        {
            position.X = newX;
        }

        public void setY(float newY)
        {
            position.Y = newY;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
            }

            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
            }

            switch(direction)
            {
                case Dir.Right:
                    position.X += speed * dt;
                    break;

                case Dir.Left:
                    position.X -= speed * dt;
                    break;

                case Dir.Up:
                    position.Y -= speed * dt;
                    break;

                case Dir.Down:
                    position.Y += speed * dt;
                    break;

                default:
                    break;
            }
        }

    }
}

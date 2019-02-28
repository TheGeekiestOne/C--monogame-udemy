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
        private bool isMoving = false;
        private KeyboardState kStateOld = Keyboard.GetState();
        private int radius = 56;
        private float healthTime = 0f;

        public AnimatedSprite anim;
        public AnimatedSprite[] animations = new AnimatedSprite[4];

        public float HealthTimer
        {
            get { return healthTime; }
            set { healthTime = value; }
        }

        public int Radius
        {
            get { return radius; }
        }

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

            if (healthTime > 0)
            {
                healthTime -= dt;
            }

            anim = animations[(int)direction];

            /* //USE ENUM TO SIMPLIFY THE BELOW!
            switch(direction)
            {
                case Dir.Down:
                    anim = animations[0];
                    break;
                case Dir.Up:
                    anim = animations[1];
                    break;
                case Dir.Left:
                    anim = animations[2];
                    break;
                case Dir.Right:
                    anim = animations[3];
                    break;
                default:
                    break;
            }
            */

            if (isMoving)
                anim.Update(gameTime);
            else
                anim.setFrame(1);

            isMoving = false;

            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
                isMoving = true;
            }

            

            if (isMoving)
            {
                switch (direction)
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

            if (kState.IsKeyDown(Keys.Space) && kStateOld.IsKeyUp(Keys.Space))
            {
                Projectile.projectiles.Add(new Projectile(position, direction));
            }

            kStateOld = kState;
        }


    }
}

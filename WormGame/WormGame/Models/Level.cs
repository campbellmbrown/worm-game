using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WormGame.Sprites;

namespace WormGame.Models
{
    public class Level
    {
        protected Player player;
        public int height = 100;
        public int width = 10;
        public Vector2 levelSize { get { return new Vector2(width, height); } }

        public Level()
        {
            player = new Player();
        }

        public void Update(GameTime gameTime)
        {
            player.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
            spriteBatch.DrawRectangle(new RectangleF(0, 0, width, height), Color.Red);
            Console.WriteLine("test");
        }
    }
}

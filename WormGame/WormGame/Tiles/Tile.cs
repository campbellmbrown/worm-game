using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormGame.Tiles
{
    public class Tile
    {
        public Vector2 position;
        protected Texture2D texture;
        public static int tileWidth = 16;

        public Tile(Vector2 position, Texture2D texture)
        {
            this.position = position;
            this.texture = texture;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position*tileWidth, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}

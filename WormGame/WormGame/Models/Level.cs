using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WormGame.Sprites;
using WormGame.Tiles;

namespace WormGame.Models
{
    public class Level
    {
        protected Player player;
        protected Vector2 levelDimensions;
        public int width { get { return (int)levelDimensions.X; } }
        public int height { get { return (int)levelDimensions.Y; } }
        public Vector2 levelSize { get { return new Vector2(width, height); } }
        protected List<Tile> backgroundTiles;
        protected List<Tile> foregroundTiles;

        public Level()
        {
            player = new Player();
            backgroundTiles = new List<Tile>();
            foregroundTiles = new List<Tile>();

            // TEMP
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    backgroundTiles.Add(new Tile(new Vector2(i, j), Game1.textures["basic_background_dark"]));
                }
            }
            // END TEMP

            levelDimensions = DetermineLevelDimensions();
        }

        protected Vector2 DetermineLevelDimensions()
        {
            Vector2 dimensions = Vector2.Zero;
            foreach (var tile in backgroundTiles)
            {
                if (tile.position.X > dimensions.X)
                    dimensions.X = tile.position.X;
                if (tile.position.Y > dimensions.Y)
                    dimensions.Y = tile.position.Y;
            }
            dimensions += Vector2.One;
            dimensions *= Tile.tileWidth;
            return dimensions;
        }

        public void Update(GameTime gameTime)
        {
            foreach (var tile in backgroundTiles) tile.Update(gameTime);
            foreach (var tile in foregroundTiles) tile.Update(gameTime);
            player.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var tile in backgroundTiles) tile.Draw(spriteBatch);
            foreach (var tile in foregroundTiles) tile.Draw(spriteBatch);
            player.Draw(spriteBatch);
        }
    }
}

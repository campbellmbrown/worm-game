using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WormGame.Models;

namespace WormGame.Managers
{
    public class LevelManager
    {
        public Level level;
        
        public LevelManager()
        {
            level = new Level();
        }

        public void Update(GameTime gameTime)
        {
            level.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            level.Draw(spriteBatch);
        }
    }
}

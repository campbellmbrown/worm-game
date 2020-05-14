using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WormGame.Tiles;

namespace WormGame.Sprites
{
    public class Player
    {
        protected List<Segment> segments;

        public Player(Vector2 middlePosition, Vector2 head1Position, Vector2 head2Position)
        {
            segments = new List<Segment>()
            {
                new Segment(middlePosition, SegmentType.Middle, new Color(176, 127, 255)),
                new Segment(head1Position, SegmentType.HeadLeftActive, new Color(255, 151, 127)),
                new Segment(head2Position, SegmentType.HeadRightInactive, new Color(206, 255, 127))
            };
        }

        public void Update(GameTime gameTime)
        {
            foreach (var segment in segments) segment.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var segment in segments) segment.Draw(spriteBatch);
        }
    }
}

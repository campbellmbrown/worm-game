using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormGame.Tiles
{
    public enum SegmentType
    {
        HeadDownActive,
        HeadUpActive,
        HeadLeftActive,
        HeadRightActive,
        HeadDownInactive,
        HeadUpInactive,
        HeadLeftInactive,
        HeadRightInactive,
        BodyCurve1,
        BodyCurve2,
        BodyCurve3,
        BodyCurve4,
        Vertical,
        Horizontal,
        Middle
    }

    public class Segment : Tile
    {
        public static int segmentSize = 16;
        protected Dictionary<SegmentType, Rectangle> textureMapping = new Dictionary<SegmentType, Rectangle>
        {
            { SegmentType.HeadDownActive, new Rectangle(0, 0, segmentSize, segmentSize) },
            { SegmentType.HeadUpActive, new Rectangle(0, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.HeadLeftActive, new Rectangle(1*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.HeadRightActive, new Rectangle(1*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.HeadDownInactive, new Rectangle(2*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.HeadUpInactive, new Rectangle(2*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.HeadLeftInactive, new Rectangle(3*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.HeadRightInactive, new Rectangle(3*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.BodyCurve1, new Rectangle(4*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.BodyCurve2, new Rectangle(4*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.BodyCurve3, new Rectangle(5*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.BodyCurve4, new Rectangle(5*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.Vertical, new Rectangle(6*segmentSize, 0, segmentSize, segmentSize) },
            { SegmentType.Horizontal, new Rectangle(6*segmentSize, 1*segmentSize, segmentSize, segmentSize) },
            { SegmentType.Middle, new Rectangle(7*segmentSize, 0, segmentSize, segmentSize) }
        };
        protected SegmentType segmentType;
        protected Color segmentColor;

        public Segment(Vector2 position, SegmentType segmentType, Color segmentColor) : base(position, Game1.textures["player"])
        {
            this.segmentType = segmentType;
            this.segmentColor = segmentColor;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position * tileWidth, textureMapping[segmentType], segmentColor, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}

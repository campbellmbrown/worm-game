﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using System;
using System.Collections.Generic;

namespace WormGame
{
    public enum GameState
    {
        Level
    }

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static Camera2D camera;

        public static Random r;
        public static float initialZoom = 4f;
        public static Dictionary<string, Texture2D> textures;
        public static Dictionary<string, SpriteFont> fonts;

        public static Vector2 screenSize { get { return new Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height); } }
        public static Vector2 zoomedScreenSize { get { return screenSize / currentZoom; } }
        public static Vector2 topLeft { get { return Vector2.Transform(Vector2.Zero, camera.GetInverseViewMatrix()); } }
        //public static Vector2 topLeft { get { return currentCamera.Position + (screenSize - zoomedScreenSize) / 2f; } }
        //public static Vector2 mousePosition { get { return Vector2.Transform(Helper.PointToVector2(Mouse.GetState().Position), currentCamera.GetInverseViewMatrix()); } }
        public static float currentZoom { get { return camera.Zoom; } }

        // States
        public static GameState gameState;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = (int)screenSize.X;
            graphics.PreferredBackBufferHeight = (int)screenSize.Y;
            graphics.IsFullScreen = false;
        }

        protected override void Initialize()
        {
            gameState = GameState.Level;
            camera = new Camera2D(GraphicsDevice) { Zoom = initialZoom, Position = -screenSize / 2f };
            IsMouseVisible = false;
            IsFixedTimeStep = true;
            graphics.SynchronizeWithVerticalRetrace = true;
            r = new Random();
            base.Initialize();
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void LoadContent()
        {
            textures = new Dictionary<string, Texture2D>()
            {
                //{ "basic_ship_main", Content.Load<Texture2D>("Ships/PlayerShips/basic_ship_main") }
            };

            fonts = new Dictionary<string, SpriteFont>()
            {
            };
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            switch (gameState)
            {
                case GameState.Level:
                    // Update the level stuff
                    break;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointWrap, DepthStencilState.None, RasterizerState.CullCounterClockwise, null, transformMatrix: camera.GetViewMatrix());
            GraphicsDevice.Clear(Color.Black);
            switch (gameState)
            {
                case GameState.Level:
                    // Draw the level stuff
                    break;
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

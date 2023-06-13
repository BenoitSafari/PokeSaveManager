using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using PokeSaveManager.Core;
using PokeSaveManager.Core.AppSettings;
using PokeSaveManager.Core.SaveGame;

namespace PokeSaveManager.Mono.src
{
    public class Main : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private readonly AppSettings _appSettings;
        private SpriteBatch _spriteBatch;
        private List<SaveFile> _userSaveFiles;

        /// <summary>
        /// Instantiates the GraphicsDeviceManager and initializes MonoGame settings
        /// </summary>
        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            _appSettings = new AppSettings();

            // MonoGame settings initialization
            Content.RootDirectory = Constants.ContentPath;
            Window.Title = $"{Constants.AppName} {Constants.AppVersion}";
            Window.AllowUserResizing = false;
            Window.AllowAltF4 = true;
            IsMouseVisible = true; // _appSettings.Content.Graphics.MouseVisibility;
            _graphics.PreferredBackBufferWidth = _appSettings.Content.Graphics.Width;
            _graphics.PreferredBackBufferHeight = _appSettings.Content.Graphics.Height;
            _graphics.IsFullScreen = false; // _appSettings.Content.Graphics.Fullscreen;
            _graphics.HardwareModeSwitch = false; // NOTE: Only borderless-fullscreen is supported
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();
            _userSaveFiles = Initializer.GetUserSaves(_appSettings.Content.SavePaths);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}

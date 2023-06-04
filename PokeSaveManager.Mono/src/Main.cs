using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using PokeSaveManager.Core;
using PokeSaveManager.Core.AppSettings;
using PokeSaveManager.Core.Services;

namespace PokeSaveManager.Mono.src
{
    public class Main : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private readonly AppSettings _appSettings = JsonService.Deserialize<AppSettings>(Constants.AppSettingsPath);

        /// <summary>
        /// Instantiates the GraphicsDeviceManager and initializes MonoGame settings
        /// </summary>
        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);

            // MonoGame settings initialization
            Content.RootDirectory = Constants.ContentPath;
            Window.Title = $"{Constants.AppName} {Constants.AppVersion}";
            Window.AllowUserResizing = false;
            Window.AllowAltF4 = true;
            IsMouseVisible = true; // _appSettings.Graphics.MouseVisibility;
            _graphics.PreferredBackBufferWidth = _appSettings.Graphics.Width;
            _graphics.PreferredBackBufferHeight = _appSettings.Graphics.Height;
            _graphics.IsFullScreen = false; // _appSettings.Graphics.Fullscreen;
            _graphics.HardwareModeSwitch = false; // NOTE: Only borderless-fullscreen is supported
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();
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

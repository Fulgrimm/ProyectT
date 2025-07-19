using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProyectT

    //PENDIENTES*
    //GENERAR SPRITES (VILLANO, CRIATURA, PERSONAJE PRINCIPAL, 2 HIJOS.

{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Declaración de variable para definir los sprites del proyecto que vamos a cargar en el metodo 
        //load content

        //TEXTURE 2D SE REFIERE A UNA IMAGEN BI-DIMENSIONAL 
        Texture2D targetSprite;
        //Inyecto mi primer sprite
        Texture2D Main;
        Texture2D backgroundSprite;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        //ESTE METODO CARGA EL CONTENIDO QUE LLAMEMOS POR LA VARIABLE, EN ESTE CASO VA A LLAMAR Texture2D
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Texture2D texture2D = Content.Load<Texture2D>("Fonddemo");
            


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

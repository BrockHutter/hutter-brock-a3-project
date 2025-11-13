using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace MohawkGame2D
{
    public class Game
    {
        float x = 0;
        float y = 0;
        Vector2 position;
        Vector2 velocity;
        Vector2 gravity = new Vector2(0, +10);

        public void Setup()
        {
            Window.SetTitle("Ascension");
            Window.SetSize(400, 600);
            position = new(Window.Width / 2, 100);
        }


        void drawPogoStick()
        {
            Draw.FillColor = Color.Black;
            Draw.Rectangle(x + 208, 520, 4, 45);
            Draw.Rectangle(x + 200, 520, 20, 4);
            Draw.FillColor = Color.Red;
            Draw.Rectangle(x + 200, 550, 20, 4);

        }

        void drawPlatform()
        {
            Draw.FillColor = Color.Green;
            Draw.Rectangle(position, 100, 30);
        }
        public void Update()
        {
            Window.ClearBackground(Color.White);
            drawPogoStick();
            ApplyGravity();
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                x -= 5;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                x += 5;
            }
            else;
            drawPlatform();
        }
        void ApplyGravity()
        {
            Vector2 gravityForce = gravity * Time.DeltaTime;
            velocity += gravityForce;
        }
    }

}

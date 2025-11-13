using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        float x = 0;
        void drawPogoStick()
        {
            Draw.FillColor = Color.Black;
            Draw.Rectangle(x + 208, 520, 4, 45);
            Draw.Rectangle(x + 200, 520, 20, 4);
            Draw.FillColor = Color.Red;
            Draw.Rectangle(x + 200, 550, 20, 4);

        }

        public void Setup()
        {
            float x = 0;
            Window.SetSize(400, 600);
        }
        public void Update()
        {
            Window.ClearBackground(Color.White);
            drawPogoStick();
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                x -= 5;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                x += 5;
            }
            else;
        }
    }

}

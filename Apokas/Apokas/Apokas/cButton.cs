﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Apokas
{
    class cButton
    {
        // start button
        Texture2D texture;
        Vector2 position;
        public Rectangle rectangle;
        // settings button
        //Texture2D sTexture;
        Rectangle sRectangle;
        // exit button
        //Texture2D eTexture;
        Rectangle eRectangle;
        Rectangle qRectangle;
        public Rectangle mouseRectangle;

        public Vector2 size;


        public cButton(Texture2D newTexture, GraphicsDevice graphics)
        {
            texture = newTexture; //ScreenWidth = 1000 ; ScreenHeight = 700
            size = new Vector2(graphics.Viewport.Width / 10, graphics.Viewport.Height / 14); // divido el viewport para cuando se cambie la resolucion, los valores se mantengan

        }
        public bool IsClicked;

        public bool sIsClicked;

        public bool eIsClicked;
        public bool qIsClicked;
        public bool tIsClicked;


        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            sRectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            eRectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            qRectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y); 
            mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1); //Rectangle del mouse

            if (mouseRectangle.Intersects(rectangle))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    IsClicked = true;
                }
                else
                {
                    IsClicked = false;
                }
            }

            if (mouseRectangle.Intersects(sRectangle))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    sIsClicked = true;
                }
                else
                {
                    sIsClicked = false;
                }
            }
            if (mouseRectangle.Intersects(eRectangle))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    eIsClicked = true;
                }
                else
                {
                    eIsClicked = false;
                }
            }
            if (mouseRectangle.Intersects(qRectangle))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    qIsClicked = true;
                }
                else
                {
                    qIsClicked = false;
                }
            }
        }

        public void setPosition(Vector2 newPositon)
        {
            position = newPositon;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace LostInSpaceLib
{
    public class Money
    {
        

        public Money(float posX, float posY)
        {
            MoneyPosition = new Vector2(posX, posY);


        }

        public Vector2 MoneyPosition { get; set; }



    }
}

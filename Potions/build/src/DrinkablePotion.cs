using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace Potions.src
{
    public class DrinkablePotion : Gun
    {
        public float drinktime = 10f;
        public bool drinked = false;

        public DrinkablePotion(float xval, float yval) : base(xval, yval)
        {
        }
    }
}

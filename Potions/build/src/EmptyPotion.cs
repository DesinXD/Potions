using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace Potions.src
{
    public class EmptyPotion : Holdable
    {
        public EmptyPotion()
        {
            this.graphic = new Sprite(GetPath("items/EmptyPotion"));
            this.center = new Vec2(0f, 0f);
            this.collisionOffset = new Vec2(8f, 8f);
            this.collisionSize = new Vec2(16f, 16f);
        }
    }
}

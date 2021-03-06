﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace Potions.src
{
    [EditorGroup("Potions")]
    public class SpeedPotion:Gun
    {
        public float drinktime = 10f;
        public bool drinked = false;

        public SpeedPotion(float xval,float yval):base(xval,yval)
        {
            this.ammo = 1;
            this._ammoType = new ATLaser();
            this.graphic = new Sprite(GetPath("items/SpeedPotion"));
            this.center = new Vec2(0f, 0f);
            this.collisionOffset = new Vec2(8f, 8f);
            this.collisionSize = new Vec2(16f, 16f);
            this._barrelOffsetTL = new Vec2(8f, 8f);
        }
        public override void OnHoldAction()
        {
            SFX.Play(GetPath("sounds/drink.ogg"));
            drinktime -= 0.1f;
            if (drinktime <= 0f)
            {
                EmptyPotion emptyPotion = new EmptyPotion();
                Level.Add(emptyPotion);
                Duck duck = this.owner as Duck;
                duck.GiveHoldable(emptyPotion);
                duck.runMax = 10f;
                Level.Remove(this);
            }
            base.OnHoldAction();
        }
        public override void OnReleaseAction()
        {
            drinktime = 10f;
            base.OnReleaseAction();
        }
        public override void OnPressAction()
        {
        }
        public override void Fire()
        {
        }
    }
}

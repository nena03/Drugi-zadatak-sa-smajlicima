﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_smajlici__drugi_primer_
{
    using System.Drawing;
    abstract class Smajli
    {
        protected int x, y;
        protected int a = 200;
        public Smajli(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Crtaj(Graphics g);
    }
}

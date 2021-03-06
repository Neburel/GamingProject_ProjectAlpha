﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicTestProject
{
    class GraphicObjectEllipse: GraphicObjects
    {
        private Brush color;

        public GraphicObjectEllipse(int x, int y, int width, int height, Direction movingDirection, Brush color) : base(x, y, width, height, movingDirection)
        {
            this.color = color;
        }

        public override void drawGraphicObject(Graphics g)
        {
            g.FillEllipse(color, pos_x, pos_y, width, height);
        }
    }
}

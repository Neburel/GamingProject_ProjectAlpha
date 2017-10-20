using GraphicTestProject.Classes.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicTestProject.Classes.View.GraphicObjects
{
    //ToDo:     Grafik für Spieler Object Implementieren
    class GraphicObject_Player : GraphicObject
    {
        Player player; 

        int x;
        int y;
        int width;
        int height;

        Brush color;

        public GraphicObject_Player(Player player, int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;

            this.width = width;
            this.height = height;

            this.player = player;
            color = Brushes.Black;
        }

        public int pos_x { get => x; set => x = value; }
        public int pos_y { get => y; set => y = value; }

        public void drawGraphicObject(Graphics g)
        {
            g.FillRectangle(color, x, y, width, height);
        }
    }
}


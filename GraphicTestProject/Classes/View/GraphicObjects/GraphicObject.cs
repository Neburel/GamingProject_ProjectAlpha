using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicTestProject.Classes.View.GraphicObjects
{
    /// <summary>
    /// Die Grundklasse aller in diesem Project verwendeten Graphischen Objekte 
    /// Sie enhält die Basis Methoden über die Jedes Graphische Object implementieren muss
    /// </summary>
    interface GraphicObject
    {
        int pos_x
        {
            get;
            set;
        }
        int pos_y
        {
            get;
            set;
        }
        /// <summary>
        /// Draws the graphic object.
        /// </summary>
        /// <param name="g">Die Zeichenobefläche auf der Gezeichnet werden soll.</param>
        void drawGraphicObject(Graphics g);
    }
}

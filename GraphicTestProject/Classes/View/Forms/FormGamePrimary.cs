using GraphicTestProject.Classes.Controller;
using GraphicTestProject.Classes.Data;
using GraphicTestProject.Classes.View.GraphicObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicTestProject.Classes.View.Forms
{
    public partial class FormGamePrimary : Form
    {
        internal List<GraphicObject> gObjects;                  //Enthält alle Graphischen Objecte (Auch den Player)
        internal GraphicObject_Player gObjectPlayer;

        private Settings_Keyboard keyboard;
        private ControlClass controlClass;

        public FormGamePrimary()
        {
            this.Visible = false;
            InitializeComponent();     //Muss zuerst ausgeführt werden da sich aktionen auf die Komponenten beziehen

            gObjects = new List<GraphicObject>();
            controlClass = new ControlClass(this);     //Besser Als übergabeparameter?
            keyboard = new Settings_Keyboard();
            
            controlClass.setUp();
            this.Visible = true;
        }
        /// <summary>
        /// Aktualisiert die Grafischen Objecte in der Form 
        /// </summary>
        public void updateGraphic()
        {
            this.Refresh();
        }

        private void FormGamePrimary_Load(object sender, EventArgs e)
        {

        }
        private void FormSpimpleAnimation_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicObject gobject in gObjects)
            {
                gobject.drawGraphicObject(e.Graphics);
            }
        }
        //Structs mit gettern und settern
        public int lblFPSText
        {
            set { lblFPS.Text = value.ToString();  }
            get
            {
                int number;
                bool result = Int32.TryParse(lblFPS.Text, out number);
                if(result == false) { throw new Exception("Attempted conversion of lblFPSText value failed"); }
                return number;
            }
        }
        public Boolean lblFPSVisible
        {
            get { return lblFPS.Visible; }
            set { lblFPS.Visible = value; }
        }
        internal GraphicObject_Player addPlayer { get => gObjectPlayer; set { gObjectPlayer = value; gObjects.Add(value); } }

        private void FormGamePrimary_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown");

            if (e.KeyData == keyboard.moveDown)
            {
                Console.WriteLine("Down");

                gObjectPlayer.pos_y = gObjectPlayer.pos_y + 100;
            }
            else if (e.KeyData == keyboard.moveUp)
            {
                gObjectPlayer.pos_y = gObjectPlayer.pos_y - 100;
            }
            else if (e.KeyData == keyboard.moveLeft)
            {
                gObjectPlayer.pos_x = gObjectPlayer.pos_x - 100;
            }
            else if (e.KeyData == keyboard.moveRight)
            {
                gObjectPlayer.pos_x = gObjectPlayer.pos_x + 100;
            }
        }
    }
}

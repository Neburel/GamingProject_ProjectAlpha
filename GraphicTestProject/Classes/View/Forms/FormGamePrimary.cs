using GraphicTestProject.Classes.Controller;
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
        public FormGamePrimary()
        {
            this.Visible = false;
            InitializeComponent();     //Muss zuerst ausgeführt werden da sich aktionen auf die Komponenten beziehen

            ControlClass controlClass = new ControlClass(this);     //Besser Als übergabeparameter?
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

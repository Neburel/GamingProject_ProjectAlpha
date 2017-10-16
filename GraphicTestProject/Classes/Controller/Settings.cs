using GraphicTestProject.Classes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicTestProject.Classes.Controller
{
    class Settings
    {
        //Vorläufige Statische fixeWerte
        private static Boolean changetoRandomdiractionforRandomobject = true;
        private static int changetoRandomdiractionforRandomobjectTimer = 20000;     //Angabe in ms 

        private static Boolean fps = true;

        //Werte die Gesetzt werden müssen
        private Player player;

        //getterSetter
        public Boolean RandomDirectionChange
        {
            get { return changetoRandomdiractionforRandomobject; }
            set { changetoRandomdiractionforRandomobject = value; }
        }
        public int RandomDirectionChangeTimer
        {
            get { return changetoRandomdiractionforRandomobjectTimer; }
            set { changetoRandomdiractionforRandomobjectTimer = value; }
        }
        public Boolean FPS
        {
            get { return fps; }
            set { fps = value; }
        }
    }
}

using GraphicTestProject.Classes.Data;
using GraphicTestProject.Classes.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GraphicTestProject.Classes.Controller
{
    //Der Name der Klasse kommt daher, das es bereits eine Klasse Control gibt (andere Benneung empfehlenswert)
    /// <summary>
    /// 
    /// </summary>
    class ControlClass
    {
        private FormGamePrimary gamingForm;
        private Settings settings;
        private Player player;
        private FPS fps;

        //TODO: Configurationen  ==> werden Settings geändert müssen hier entsprechende anpassungen Vorgenommen werden 
        //                       ==> Player durch XML Laden
        //                       ==> Graphisches Object zu ende Implementieren
        //                       ==> ID verwaltung Implementieren
        
        //Kommentare
        //FPS ist Aktuell Fest verankert, nur die Sichtbarkeit kann an oder Ausgestellt werden
        //Die Player Klasse wird so interpretriert das es ein Spezifischer Player ist, der Selbstständig sein Graphisches Object erzeugt

        public ControlClass(FormGamePrimary gamingForm)
        {
            this.gamingForm = gamingForm;
        }
        //Aufbau des Programms
        /// <summary>
        /// Baut das Programm nach den in Settings Configurierten Eigenschaften auf
        /// </summary>
        public void setUp()
        {
            settings = new Settings();

            setUpPlayer();
            setUpGraphicUpdate();
            setUpFPS();
        }
        /// <summary>
        /// Sets up graphic update.
        /// </summary>
        private void setUpGraphicUpdate()
        {
            Timer graphicUpdateTimer = new Timer();
            graphicUpdateTimer.Interval = 20;
            graphicUpdateTimer.Tick += new EventHandler(EventGraphicUpdate);
            graphicUpdateTimer.Start();
        }
        /// <summary>
        /// Baut die FPS Berechnung auf
        /// </summary>
        private void setUpFPS()
        {
            if(settings.FPS == true) { gamingForm.lblFPSVisible = true; }
            if(settings.FPS == false) { gamingForm.lblFPSVisible = false; }

            fps = new FPS();

            Timer fpsTimer = new Timer();
            fpsTimer.Interval = 1000;
            fpsTimer.Tick += new EventHandler(EventFPS);
            fpsTimer.Start();
        }
        private void setUpPlayer()
        {
            player = new Player_PlayerOne(1, "Player");
            gamingForm.addPlayer = player.GObject;


        }
        //Reaktionen auf Signale    
        private void EventGraphicUpdate(object sender, EventArgs e)
        {
            fps.OnMapUpdated();
            gamingForm.updateGraphic();
        }
        /// <summary>
        /// Event das zur Berechnung der FPS Genutzt wird. 
        /// Es muss jede Sekunde Aufgerufen werden
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EventFPS(object sender, EventArgs e)
        {
            gamingForm.lblFPSText = (int)fps.GetFps();
        }

    }
}

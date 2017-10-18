using GraphicTestProject.Classes.View.GraphicObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicTestProject.Classes.Data
{
    /// <summary>
    /// Interface für alle Spielerklassen
    /// Stellt sicher das Alle unterschiedlich Implementierten Spieler alle Benötigten Komponenten besitzen
    /// </summary>
    interface Player
    {
        String PlayerName{get;set;}
        int HP{get;set;}
        int MP{get;set;}
        int XP{set;get;}
        Item getItemFromInventory(int index);
        GraphicObject_Player GObject { get; set; }
    }
}


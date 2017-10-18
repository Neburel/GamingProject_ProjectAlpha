using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicTestProject.Classes.View.GraphicObjects;

namespace GraphicTestProject.Classes.Data
{
    class Player_PlayerOne : Entity , Player
    {
        // Attribute declaration
        private String playerName;
        private int hp;
        private int mp;
        private int xp;
        private Item[] inventory; //TODO: Anzahl beachten
        private GraphicObject_Player gPlayer;

        // Getter & Setter
        string Player.PlayerName { get => playerName; set => playerName = value; }
        int Player.HP { get => hp; set => hp = value; }
        int Player.MP { get => mp; set => mp = value; }
        int Player.XP { get => xp; set => xp = value; }
        public GraphicObject_Player GObject { get => gPlayer; set => gPlayer = value; }

        // Inventory Methods
        Item Player.getItemFromInventory(int index)
        {
            return inventory[index];
        }

        // Constructor
        public Player_PlayerOne(int id, String name) : base(id, Type.Player)
        {
            this.playerName = name;
            this.hp = 100;
            this.mp = 100;
            this.xp = 0;
            this.inventory = new Item[0];

            gPlayer = new GraphicObject_Player(this, 10, 10, 10, 10);
        }
    }
}

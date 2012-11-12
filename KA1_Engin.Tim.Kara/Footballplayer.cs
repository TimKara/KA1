using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KA1_Engin.Tim.Kara
{
    [Serializable]
    public class Footballplayer : Person
    {
        // instance variables
        protected int player_number, height, weight, age;

        // constructor
        public Footballplayer(string name, string address, int telephone, string password, int userlevel, int player_number, int height, int weight, int age)
            : base(name, address, telephone, password, userlevel)
        {
            this.player_number = player_number;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }

        // Age property
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // Weight property
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        // Height property
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        // Player_number property
        public int Player_number
        {
            get { return player_number; }
            set { player_number = value; }
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + " | Player number: " + player_number + " | Height: " + height + " | Weight: " + weight + " | Age: " + age;
        }
    }
}
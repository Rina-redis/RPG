﻿namespace TestApp.Models
{
    public class Character
    {
        public Character()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intrlligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Mage;


    }
}

﻿namespace WOIHelper.Data.Models
{
    public class Stardust : Item
    {
        public Stardust(string name, Requirement[] requirements)
        {
            Name = name;
            Requirements = requirements;
        }

        public Requirement[] Requirements { get; set; }
    }
}
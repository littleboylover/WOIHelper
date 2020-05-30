﻿namespace WOIHelper.Data.Models
{
    public class ComboBoxItem
    {
        public ComboBoxItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
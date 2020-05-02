using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Models
{
    public class Character
    {

        public String Name { get; set; }
        public String Description { get; set; }
        public String Thumbnail { get; set; }

        public Character() { }

        public Character(String name, String description, String thumbnail)
        {
            this.Name = name;
            this.Description = description;
            this.Thumbnail = thumbnail;
        }

    }
}

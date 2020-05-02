using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Models
{
    public class Achievement
    {

        public String Name { get; set; }
        public String Description { get; set; }

        public Achievement() { }
        public Achievement(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }

    }
}

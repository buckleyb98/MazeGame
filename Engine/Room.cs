using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Room(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
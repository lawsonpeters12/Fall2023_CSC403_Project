using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{    
    public class Item
    {
        public Collider Collider { get; set; }
        public Vector2 Position { get; set; }
        public Image Img { get; set; }

        public Item(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;
        }
        
    }
}

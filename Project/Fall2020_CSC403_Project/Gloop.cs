using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public class Gloop : Character
    {
        public Gloop(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            
        }
        
        public static Gloop MakeGloop(PictureBox picGloop)
        {
            return new Gloop(new Vector2(picGloop.Location.X, picGloop.Location.Y),
                new Collider(new Rectangle(picGloop.Location, 
                    new Size(picGloop.Size.Width - 7, picGloop.Size.Height - 7))));
        }
    }
}
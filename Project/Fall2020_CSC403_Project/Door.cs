using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public class Door : Character
    {
        public Vector2 SpawnPoint { get; }
        public FrmLevelBase TargetLevel { get; }
        
        public Door(Vector2 initPos, Collider collider, Vector2 spawnPoint, FrmLevelBase targetLevel) : base(initPos, collider)
        {
            SpawnPoint = spawnPoint;
            TargetLevel = targetLevel;
        }

        public static Door MakeDoor(PictureBox picDoor, Vector2 spawnPoint, FrmLevelBase targetLevel)
        {
            return new Door(new Vector2(picDoor.Location.X, picDoor.Location.Y),
                new Collider(new Rectangle(picDoor.Location,
                    new Size(picDoor.Size.Width - 7, picDoor.Size.Height - 7))), spawnPoint, targetLevel);
        }
    }
}
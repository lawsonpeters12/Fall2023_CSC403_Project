﻿namespace Fall2020_CSC403_Project.code
{
    public class Character
    {
        public int GO_INC = 3; // might have to change this for move speed, just need to change it back after you stop colliding with gloop

        public Vector2 MoveSpeed { get; set; }
        public Vector2 LastPosition { get; private set; }
        public Vector2 Position { get; set; }
        public Collider Collider { get; private set; }

        public Character(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;
        }

        public void Move()
        {
            LastPosition = Position;
            Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }

        public void MoveBack()
        {
            Position = LastPosition;
        }

        public void GoLeft()
        {
            MoveSpeed = new Vector2(-GO_INC, 0);
        }
        public void GoRight()
        {
            MoveSpeed = new Vector2(+GO_INC, 0);
        }
        public void GoUp()
        {
            MoveSpeed = new Vector2(0, -GO_INC);
        }
        public void GoDown()
        {
            MoveSpeed = new Vector2(0, +GO_INC);
        }

        public void GoUpLeft()
        {
            MoveSpeed = new Vector2(-GO_INC, -GO_INC);
        }

        public void GoDownLeft()
        {
            MoveSpeed = new Vector2(-GO_INC, +GO_INC);
        }

        public void GoUpRight()
        {
            MoveSpeed = new Vector2(+GO_INC, -GO_INC);
        }

        public void GoDownRight()
        {
            MoveSpeed = new Vector2(+GO_INC, +GO_INC);
        }

        public void ResetMoveSpeed()
        {
            MoveSpeed = new Vector2(0, 0);
        }

    }
}
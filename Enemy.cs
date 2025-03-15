using System;

namespace PlaneWar
{
    class Enemy
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public void Move()
        {
            Y++;
        }
        
        public bool IsCollidingWith(Player player)
        {
            return X == player.X && Y == player.Y;
        }
    }
}
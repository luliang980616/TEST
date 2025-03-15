using System;

namespace PlaneWar
{
    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Player()
        {
            X = 0;
            Y = 0;
        }
        
        public void MoveLeft()
        {
            X--;
        }
        
        public void MoveRight()
        {
            X++;
        }
        
        public void Shoot()
        {
            // 发射子弹逻辑
        }
    }
}
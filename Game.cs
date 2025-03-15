using System;

namespace PlaneWar
{
    class Game
    {
        private Player player;
        private List<Enemy> enemies;
        
        public Game()
        {
            player = new Player();
            enemies = new List<Enemy>();
        }
        
        public void Run()
        {
            while(true)
            {
                Update();
                Draw();
                System.Threading.Thread.Sleep(100);
            }
        }
        
        private void Update()
        {
            // 更新游戏逻辑
        }
        
        private void Draw()
        {
            // 绘制游戏画面
        }
    }
}
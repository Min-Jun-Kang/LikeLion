using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    class Program
    {
        //실행만 시키는 곳
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame(); // maingame 객체 생성
            mainGame.Initialize(); //게임 초기화(초기 화면)
            mainGame.Progress(); //게임 화면
            
        }
    }
}

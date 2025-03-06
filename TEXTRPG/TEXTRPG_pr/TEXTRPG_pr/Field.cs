using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class Field
    {
        //몬스터와 플레이어가 싸우는 공간

        Player player = null; //플레이어 객체
        Monster monster = null; //몬스터 객체

        //MainGame에서 생성한 플레이어 불러오기
        public void SetPlayer(ref Player pPlayer) //ref를 활용하여 포인터 주소를 공유하여 만든 player를 데리고 옴
        {
            player = pPlayer;
        }


    }
}

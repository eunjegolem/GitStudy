using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    //플레이어 객체
    class Player
    {
        //구성요소(변수 : 정보) : 명사
        private int level = 1;
        private int hp = 10;
        private int attackPoint = 10;

        //행동(함수) : 동사
        public void Atteck(Monster monster)//공개여부 반환여부 함수명:행동명(매개변수:타겟)
        {
            Console.WriteLine("플레이어가 몬스터를 공격합니다.");
            monster.TakeHit(attackPoint);
            Console.WriteLine("플레이어의 공격을 종료합니다.");
        }
        public void DoubleAtteck(Monster monster1, Monster monster2)//공개여부 반환여부 함수명:행동명(매개변수:타겟)
        {
            Console.WriteLine("플레이어가 몬스터를 한 번에 두 번 공격합니다.");
            monster1.TakeHit(attackPoint);
            monster2.TakeHit(attackPoint);
            Console.WriteLine("플레이어의 공격을 종료합니다.");
        }



    }
}

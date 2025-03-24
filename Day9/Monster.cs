using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    //몬스터 객체
    class Monster
    {
        public string name;
        public int level;
        public int hp;

        public void TakeHit(int attackPoint)
        {
            Console.WriteLine("몬스터가 피격을 받습니다.");
            hp -= attackPoint;
            Console.WriteLine("몬스터의 체력은 {0}입니다.", hp);
            if (hp <= 0)
            {
                Die();
            }
        }

        //다른 곳에서 직접 선택할 수 없게 비공개함 : TakeHit에서만 접근하여 호출
        private void Die()
        {
            Console.WriteLine("몬스터가 쓰러집니다.");
        }

        //생성자 : C#에서는 적지 않아도 자동으로 빈값, 0 으로 생성해줌
        public Monster()
        {
            name = "몬스터";
            level = 1;
            hp = 10;
        }
        //생성자에 추가정보를 넣어서 만들 수도 있음
        public Monster(string _name, int _hp, int _level)
        {
            name = _name;
            hp = _hp;
            level = _level;

        }

        //생성자의 레시피를 만들어 놓을 수 있음
        public Monster(string _name)
        {

            switch (name)
            {
                case "드래곤":
                    name = "드래곤";
                    hp = 100;
                    level = 1000;
                    break;
                case "슬라임":
                    name = "슬라임";
                    hp = 3;
                    level = 1;
                    break;
                case "오크":
                    name = "오크";
                    hp = 10;
                    level = 10;
                    break;
            }
        }


    }
}

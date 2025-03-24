using System;
//namespace 가 같으면 클래스를 쓸 수 있음
//만약에 다르면 using namespace 를 입력해야함


namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체지향
            //인스턴스 생성
            Player player = new Player();
            Monster monster = new Monster();

            //설정값을 놓칠 수도 있으니
            monster.name = "드래곤";
            monster.level = 1000;
            //monster.hp = ???? 입력을 안함

            //내용을 넣어서 생성자를 통해서 만들 수 있음
            //(매개변수 없는 생성자를 안만들면 필수값을 받게 할 수 있음 : 그때는 자동 생성이 안됨)
            Monster slime = new Monster("슬라임", 100, 3);

            Monster orc = new Monster("오크");

            player.Atteck(monster);             //player attcek monster




            /*
            //절체지향 : 메인에 다 적어 넣어야 함
            //플레이어가 몬스터 공격하기
            //1. 플레이어 공격력 설정
            //2. 몬스터 체력 설정
            //3. 플레이어 공격력 만큼 몬스터 체력감소
            */
        }
    }
}

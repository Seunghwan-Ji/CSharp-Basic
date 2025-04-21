// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Player
{
    // 멤버변수 -> 클래스 내부에 있다고 해서 멤버변수.
    int ATT;
    int HP;

    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }
} // 게임에서 사용하기 위해서 여기까지 설계했다.

namespace _06LocalVar
{
    // C#은 고지식한 객체지향 언어.
    // 클래스 밖에 모르는 바보.
    // 프로그램의 시작 조차도 클래스 안에 묶어놔야 한다.
    class Program
    {
        // 시작용 함수.
        static void Main(string[] args)
        {
            // 클래스 안에 있는 변수는 멤버변수.
            // 함수 안에 있는 변수는 지역변수.
            int ATT = 0;
            // 지역변수는 내부에서만 사용 가능.

            Player NewPlayer = new Player(); // 객체화라고 하는 굉장히 중요한 작업.
            // Player 클래스의 설계대로 플레이어를 만드는데,
            // 그 이름을 NewPlayer라고 짓겠다.
        }
    }
}
// 클래스 = 설계도
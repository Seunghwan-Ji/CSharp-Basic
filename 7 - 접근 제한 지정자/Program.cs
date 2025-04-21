using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{ // -> 클래스의 내부.
    // 접근 제한 지정자: 객체지향의 캡슐화 은닉화를 대표하는 문법.
    public int HP; // 외부에도 공개.
    private int ATT; // 외부에 비공개.
    protected int DEF; // 자식에게만 공개.

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
} // -> 클래스의 끝.

// -> 클래스의 외부.

namespace _07ClassAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            
            NewPlayer.HP = 100; // public: 외부에서 접근 가능.
            NewPlayer.Fight(); // public: 외부에서 접근 가능.
        }
    }
}

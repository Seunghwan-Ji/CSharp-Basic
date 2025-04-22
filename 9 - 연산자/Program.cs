using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;

    void Damage(int _HP)
    {
        HP -= _HP;
    }

    // 연산자는 함수와 비슷함.
    // Ex) 덧셈
    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }
}

namespace _09Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // = 대입 연산자
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // 산술 연산자
            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;
            // 나눗셈과 나머지에서는 0을 넣으면 안됨.
            // 수학에서 0으로 나누는 것은 정의되지 않은 것처럼,
            // 컴퓨터에서는 제로 디비전이라고 해서 오류가 발생함.

            bool BResult = true;
            BResult = false;

            // 비교 연산자
            BResult = Left > Right;
            BResult = Left < Right;
            BResult = Left <= Right;
            BResult = Left >= Right;
            BResult = Left == Right;
            BResult = Left != Right;

            // 논리 연산자
            BResult = true && false; // AND
            BResult = true || false; // OR
            BResult = !true; // NOT
            BResult = true ^ false; // XOR(양쪽이 다르면 true, 같으면 false)

            // 축약 대입 연산자
            // +=, -=, *=, /=, %=
        }
    }
}

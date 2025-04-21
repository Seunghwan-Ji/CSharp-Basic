using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근 제한 지정자를 정의하지 않으면 기본적으로 private.
    // 이유는 private 가 일반적이기 때문이다.
    // 속성들은 외부에서 접근하지 못하게 하는게 일반적으로 좋다.
    // 멤버함수로 접근하는 것을 권장.
    private int LV = 1;
    private int HP = 100;
    private int ATT = 10;

    public void LVUP()
    {
        HP += 10;
        ATT += 5;
    }

    // 플레이어의 레벨이 몇인지 알고싶다.
    // 리턴값을 활용해 객체가 자신의 상태를 외부에 알릴 수 있다.
    public int GetLV()
    {
        return LV;
    }

    public void SetHP(int _HP)
    {
        HP = _HP;
    }

    // void[리턴값] Func[함수 이름 혹은 식별자] ()[인자값]
    public void Func()
    {
    }
    
    // 함수는 보통 클래스 외부와의 소통을 위헤서 만든다.

    public void Damage1(int _Dmg)
    {
        HP -= _Dmg;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP -= _Dmg;
        HP -= _SubDmg;
    }

    // 리턴값은 자신이 리턴 해주려는 자료형과 동일한 자료형 이어야 한다.
    public int DamageToHPReturn(int _Dmg)
    {
        HP -= _Dmg;
        return HP;
    }
}

namespace _08FuncEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // NewPlayer.LVUP();

            // NewPlayer.SetHP(0);

            // 이런식으로 외부의 값을 받아서, 객체 내부의 상태를 변화시키기 위해
            // 함수를 선언하는 경우가 많다.
            // NewPlayer.Damage1(10);
            // NewPlayer.Damage1(20);
            // NewPlayer.Damage2(20, 5);

            Console.WriteLine(NewPlayer.GetLV());

            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}

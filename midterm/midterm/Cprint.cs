using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    interface IPrint
    {
        void Thousand(int _Money);
        void PokerWhat(int _CardNum);
    }
    public class Cprint : IPrint
    {
        public void Thousand(int _Money)
        {
            Console.WriteLine(String.Format("{0: 0,0 }", _Money)); //형변환
        }
        
        public void PokerWhat(int _CardNum)
        {
            int x, y;
            x = _CardNum/4;
            y = _CardNum%4; 
            string N = "null"; //y값에 따른 모양
            string F = "null"; //x값에 따른 숫자
            //if값으로 몫 나머지 따라 모양 출력 number = "문자" 

            if (y == 0)
            {
                N = "◆";
                    if(x == 0)
                    {
                        F = "A";
                    }
                    else if (x == 10)
                    {
                        F = "J";
                    }
                    else if (x == 11)
                    {
                        F = "Q";
                    }
                    else if (x == 12)
                    {
                        F = "K";
                    }
                else {
                x+=1;
                F = String.Format("{0}",x); // 아무 것도 해당안할 때는 x값에 +1해서(0~8이니까) 문자열로 출력하게 두어라

            }
              
               
            }
            
            else if (y == 1)
            {           
                N = "♣";
                    if(x == 0)
                    {
                        F = "A";
                    }
                    else if (x == 10)
                    {
                        F = "J";
                    }
                    else if (x == 11)
                    {
                        F = "Q";
                    }
                    else if (x == 12)
                    {
                        F = "K";
                    }
                else {
                x+=1;
                F = String.Format("{0}",x); // 아무 것도 해당안할 때는 x값에 +1해서(0~8이니까) 문자열로 출력하게 두어라

            }
              
               
            }
            
            else if (y == 2)
            {
                N = "♥";
                    if(x == 0)
                    {
                        F = "A";
                    }
                    else if (x == 10)
                    {
                        F = "J";
                    }
                    else if (x == 11)
                    {
                        F = "Q";
                    }
                    else if (x == 12)
                    {
                        F = "K";
                    }
                else {
                x+=1;
                F = String.Format("{0}",x); // 아무 것도 해당안할 때는 x값에 +1해서(0~8이니까) 문자열로 출력하게 두어라

            }
              
               
            }
            
            else
            {
                N = "♠";
                    if(x == 0)
                    {
                        F = "A";
                    }
                    else if (x == 10)
                    {
                        F = "J";
                    }
                    else if (x == 11)
                    {
                        F = "Q";
                    }
                    else if (x == 12)
                    {
                        F = "K";
                    }
                else {
                x+=1;
                F = String.Format("{0}",x); // 아무 것도 해당안할 때는 x값에 +1해서(0~8이니까) 문자열로 출력하게 두어라

            }
              
               
            }
            
            
              Console.WriteLine("{0},{1}",N,F); //F와 N을 출력해라({0},{1}에다가
            }
        public void Intro()
        {
            Console.WriteLine("POKER GAME");
            Console.WriteLine("시작하겠습니까?(시작 시 자동 1000원 배팅)");
            Console.WriteLine("예 :Y, 아니오 : N");
            Console.WriteLine("언제든 종료를 원할 시 X를 누르시오.");
        }
        public void Batt()
        {
            
            Console.WriteLine("1000원 배팅하겠습니까?");
            Console.WriteLine("예 :Y, 아니오 : N");
            
        }
        public void Score(int score)
        {
            if (score == 9)
            {
                Console.WriteLine("로얄 스트레이트 플러시입니다.");
            }
            else if (score == 8)
            {
                Console.WriteLine("스트레이트 플러시입니다.");
            }
            else if (score == 7)
            {
                Console.WriteLine("포커입니다.");
            }
            else if (score == 6)
            {
                Console.WriteLine("풀하우스입니다.");
            }
            else if (score == 5)
            {
                Console.WriteLine("스트레이트입니다.");
            }
            else if (score == 4)
            {
                Console.WriteLine("플러시입니다.");
            }
            else if (score == 3)
            {
                Console.WriteLine("트리플입니다.");
            }
            else if (score == 2)
            {
                Console.WriteLine("투페어입니다.");
            }
            else if (score == 1)
            {
                Console.WriteLine("원페어입니다.");
            }
            else
                Console.WriteLine("아무 조합도 없습니다.");
        }
        public void Win(){
            Console.WriteLine("승리하였습니다!");
            Console.WriteLine("다시 하겠습니까?");
            Console.WriteLine("예 :Y, 아니오 : N");

        }
        public void Lose(){
            Console.WriteLine("패배하였습니다...");
            Console.WriteLine("다시 하겠습니까?");
            Console.WriteLine("예 :Y, 아니오 : N");
        
        }
        public void End()
        {
            Console.WriteLine("나가셔도 좋습니다.");
        }
        }
    }
    

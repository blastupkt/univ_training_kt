using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class program
    {
        static void Main(string[] args)
        {
            Shuffle Shu = new Shuffle();
            PLCard PL = new PLCard();
            ComPuterCard CPU = new ComPuterCard();
            CMan Cman = new CMan();
            Cprint CPrint = new Cprint();
            DeckScore DS = new DeckScore();
            

            
            while (true)
            {
                CPrint.Intro();
                Console.Write("Your Money : ");
                CPrint.Thousand(Cman.PMoney);
                Console.Write("CPU Money : ");
                CPrint.Thousand(Cman.CMoney);
                if ((Cman.PMoney < 3000) || (Cman.CMoney < 3000))
                {
                    Console.WriteLine("돈이 없습니다.");
                    break;
                }
                string val = Console.ReadLine();
                
                if (val == "X")
                {
                    break;
                }
                if (val == "N")
                {
                    break;
                }
               
                
                else
                {

                    Shu.Mix_Deck(Shu.Poker_total);

                    Cman.CMoney -= 1000;
                    Cman.PMoney -= 1000;
                    Cman.PanMoney += 2000;

                    Console.Write("Your Money : ");
                    CPrint.Thousand(Cman.PMoney);
                    Console.Write("CPU Money : ");
                    CPrint.Thousand(Cman.CMoney);

                    
                    Array.Copy(Shu.Poker_total, PL.PlayerCard, 3);
                    Array.Copy(Shu.Poker_total, 3, CPU.CPUCard, 0, 3);

                    Console.WriteLine("Your Deck: ");
                    for (int i = 0; i < 3; i++)
                    {
                        CPrint.PokerWhat(PL.PlayerCard[i]);
                    }

                    CPrint.Batt();
                }
                if ((Cman.PMoney < 2000) || (Cman.CMoney < 2000))
                {
                    Console.WriteLine("돈이 없습니다.");
                    break;
                }
                string val2 = Console.ReadLine();
              
                if (val2 == "X")
                {
                    break;
                }
                if (val2 == "N")
                {
                    
                        Cman.CMoney += Cman.PanMoney;
                        Cman.PanMoney = 0;
                        CPrint.Lose();
                        string val4 = Console.ReadLine();
                        if (val4 == "Y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (val4 == "N")
                        {
                            break;
                        }
                    
                }
                
                else
                {

                    Cman.CMoney -= 1000;
                    Cman.PMoney -= 1000;
                    Cman.PanMoney += 2000;

                    Console.Write("Your Money : ");
                    CPrint.Thousand(Cman.PMoney);
                    Console.Write("CPU Money : ");
                    CPrint.Thousand(Cman.CMoney);

                    Array.Copy(Shu.Poker_total, 6, PL.PlayerCard, 3, 4);
                    Array.Copy(Shu.Poker_total, 10, CPU.CPUCard, 3, 4);

                    Console.WriteLine("Your Deck: ");
                    for (int i = 0; i < 7; i++)
                    {
                        CPrint.PokerWhat(PL.PlayerCard[i]);
                    }

                    CPrint.Batt();
                }
                if ((Cman.PMoney < 1000) || (Cman.CMoney < 1000))
                {
                    Console.WriteLine("돈이 없습니다.");
                    break;
                }
                string val3 = Console.ReadLine();
                if (val3 == "X")
                {
                    break;
                }
                if (val3 == "N")
                {
                    Cman.CMoney += Cman.PanMoney;
                    Cman.PanMoney = 0;
                    CPrint.Lose();
                    string val4 = Console.ReadLine();
                    if (val4 == "Y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (val4 == "N")
                    {
                        break;
                    }

                }
                else
                {

                    Cman.CMoney -= 1000;
                    Cman.PMoney -= 1000;
                    Cman.PanMoney += 2000;

                    Console.Write("Your Money : ");
                    CPrint.Thousand(Cman.PMoney);
                    Console.Write("CPU Money : ");
                    CPrint.Thousand(Cman.CMoney);

                    Console.WriteLine("CPU's Deck: ");
                    for (int i = 0; i < 7; i++)
                    {
                        CPrint.PokerWhat(CPU.CPUCard[i]);
                    }
                   
                  
                    DS.LoyalSTFlush(PL.PlayerCard);
                    DS.LoyalSTFlush(CPU.CPUCard);

                    DS.ST(PL.PlayerCard);
                    DS.Flush(PL.PlayerCard);
                    DS.Flush(CPU.CPUCard);
                    DS.ST(CPU.CPUCard);

                    DS.STFlush(PL.PlayerCard);
                    DS.STFlush(CPU.CPUCard);

                    DS.Poker(PL.PlayerCard);
                    DS.FullH(PL.PlayerCard);
                    DS.Triple(PL.PlayerCard);
                    DS.TwoP(PL.PlayerCard);
                    DS.OneP(PL.PlayerCard);

                    DS.Poker(CPU.CPUCard);
                    DS.FullH(CPU.CPUCard);
                    DS.Triple(CPU.CPUCard);
                    DS.TwoP(CPU.CPUCard);
                    DS.OneP(CPU.CPUCard);


                    DS.Score(CPU.CPUCard);
                    DS.Score(PL.PlayerCard);


            Console.Write("Player : ");
            CPrint.Score(Cman.PResult);
            Console.Write("CPU : ");
            CPrint.Score(Cman.PResult);

                    //여기에 나누기 식 결과 적어넣는다
                    if (Cman.PResult > Cman.CResult)
                    {
                        Cman.PMoney += Cman.PanMoney;
                        Cman.PanMoney = 0;
                        CPrint.Win();
                        string val4 = Console.ReadLine();
                        if (val4 == "Y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (val4 == "N")
                        {
                            break;
                        }
                    }
                    else if (Cman.PResult < Cman.CResult)
                    {
                        Cman.CMoney += Cman.PanMoney;
                        Cman.PanMoney = 0;
                        CPrint.Lose();
                        string val4 = Console.ReadLine();
                        if (val4 == "Y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (val4 == "N")
                        {
                            break;
                        }
                    }
                    else
                    {
                        Cman.CMoney += 3000;
                        Cman.PMoney += 3000;
                        Cman.PanMoney = 0;
                        Console.WriteLine("비겼습니다. 다시 하겠습니까?");
                        Console.WriteLine("예 :Y, 아니오 : N");
                        string val4 = Console.ReadLine();
                        if (val4 == "Y")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (val4 == "N")
                        {
                            break;
                        }
                    }
                }
            }

            CPrint.End();
        }
    }
}

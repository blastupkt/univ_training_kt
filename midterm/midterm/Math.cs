using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class Shuffle
    {
        public int[] Poker_total = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };
        public void Mix_Deck(int []Poker_Mixed)
        {

            int _size = Poker_Mixed.Length;
            int[] tmp = new int[_size];
            int v1 = 0, v2 = 0, v3 = _size;

            for (int i = 0; i < _size; i++)
                tmp[i] = i;

            //mixing
            Random r = new Random();
            while (v3 > 0)
            {
                //패를 뽑는다.
                v2 = r.Next(v3);

                //패를 저장.
                Poker_total[v1] = tmp[v2];

                //뽑은 패가 끝이 아니라면 ..
                if (v2 != v3 - 1)
                {
                    //끝에 있는 수를 비어있는 공간에 설정.
                    tmp[v2] = tmp[v3 - 1];

                }

                v3--; //전체 수를 하루 줄인다.
                v1++; //저장 할 index를 하나 늘린다.
            }
        }
        
        public void Score(int []Poker_Deck)
        {
            /* CMan Cman = new CMan();

            if (Poker_Deck[0] = 3){
                Cman.CResult = 10;
            }*/
           
        }
        
   
    }
    class DeckScore
    {
        
        
        PLCard PL = new PLCard();
        ComPuterCard CPU = new ComPuterCard();
        CMan Cman = new CMan();
       
        //정렬 sort 한 번 해주고
        //0 : 노페어 1: 원페어 2: 투페어 

          public bool LoyalSTFlush(int []card)
        {
            
            
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (card[i] % 4 == 3)
                    if (card[i] / 4 == 0 || card[i] / 4 == 9 || card[i] / 4 == 10 || card[i] / 4 == 11 || card[i] / 4 == 12)
                    {
                        count++;
                    }
            }
            if (count == 5)
            { return true;}
            else return false;

        }
         public bool ST(int []card) //몫 
           {
               int[] Card = new int[7];
               for (int i = 0; i < 7; i++)
               {
                   Card[i] = card[i] / 4;
               }
               Array.Sort(Card);
               int count = 0;
                 
                        for (int i = 0; i < 6; i++)
                {
              

                   if (Card[i] + 1 == Card[i + 1]) count++;
                    
                }
              
              if (count == 4) return true;
              else return false;


           }
        public bool Flush(int []card) //나머지
          {
              int[] Card = new int[7];
              for (int i = 0; i < 7; i++)
              {
                  Card[i] = card[i] % 4;
              }
              Array.Sort(Card);
              for (int i = 0; i < 3; i++)
              { 
                  if (Card[i] == Card[i + 1] && Card[i + 1] == Card[i + 2] && Card[i + 2] == Card[i + 3] && Card[i + 3] == Card[i + 4]) //1~5번째 
                    return true;
              }
             return false;

          }
        public bool STFlush(int []card)
        {

            if (ST(card) == true && Flush(card) == true)
            {
                return true;
            }
            else return false;
        }
        

        public bool Poker(int []card) // 몫
        {
            int[] Card = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Card[i] = card[i] / 4;
            }
            Array.Sort(Card);
            for (int i = 0; i < 4; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 1] == Card[i + 2] && Card[i+2] == Card[i+3]) //1~5번째 
                    return true;
            } 
           
            return false;

        }
        
        public bool Triple(int []card) // 몫
        {
            int[] Card = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Card[i] = card[i] / 4;
            }
            Array.Sort(Card);
            
            for (int i = 0; i < 5; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 1] == Card[i + 2]) //1~5번째 
                    return true;
            }
            return false;

        }
       public bool TwoP(int[] card) // 몫
        {
            int[] Card = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Card[i] = card[i] / 4;
            }
            Array.Sort(Card);
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Card[i] == Card[i + 1]) //1~5번째 
                    count++;
            }
            if (count == 2)
                return true;
            else return false;

        }

        public bool OneP(int[] card) // 몫
        {
            int[] Card = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Card[i] = card[i] / 4;
            }
            Array.Sort(Card);

            for (int i = 0; i < 6; i++)
            {
                if (Card[i] == Card[i + 1]) //1~5번째 
                    return true;
            }
            return false;

        }
         public bool FullH(int[] card) // 몫
        {
            int[] Card = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Card[i] = card[i] / 4;
            }   
            Array.Sort(Card);
              for (int i = 0; i < 3; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 2] == Card[i + 3] && Card[i + 4] == Card[i + 4]) //1~5번째                     
                    return true;
            }
            for (int i = 0; i < 3; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 1] == Card[i + 2] && Card[i + 2] == Card[i + 3] && Card[i+3] == Card[1+4]) //1~5번째                     
                    return true;
            }
            for (int i = 0; i < 2; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 2] == Card[i + 3] && Card[i + 4] == Card[i + 4]) //1~5번째                     
                    return true;
            }
            for (int i = 0; i < 2; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 3] == Card[i + 4] && Card[i + 4] == Card[i + 5]) //1~5번째                     
                    return true;
            }
            for (int i = 0; i < 2; i++)
            {
                if (Card[i] == Card[i + 1] && Card[i + 1] == Card[i + 2] && Card[i + 4] == Card[i + 5]) //1~5번째                     
                    return true;
            }
            if (Card[0] == Card[1] && Card[4] == Card[5] && Card[5] == Card[6]) //1~5번째                     
                return true;
            if (Card[0] == Card[1] && Card[1] == Card[2] && Card[5] == Card[6]) //1~5번째                     
                return true;
            

            else return false;
        }
         public void Score(int[] card)
         {

             while (true)
             {

                 if (LoyalSTFlush(card) == true)
                 {
                     Cman.CResult = 9;

                     break;
                 }
                 else if (STFlush(card) == true)
                 {
                     Cman.CResult = 8;

                     break;
                 }
                 else if (Poker(card) == true)
                 {
                     Cman.CResult = 7;

                     break;
                 }
                 else if (FullH(card) == true)
                 {
                     Cman.CResult = 6;

                     break;
                 }
                 else if (ST(card) == true)
                 {
                     Cman.CResult = 5;

                     break;
                 }
                 else if (Flush(card) == true)
                 {
                     Cman.CResult = 4;

                     break;
                 }
                 else if (Triple(card) == true)
                 {
                     Cman.CResult = 3;

                     break;
                 }
                 else if (TwoP(card) == true)
                 {
                     Cman.CResult = 2;

                     break;
                 }
                 else if (OneP(card) == true)
                 {
                     Cman.CResult = 1;

                     break;
                 }
                 else
                     Cman.CResult = 0;

                 break;
             }
         }
        
     
     
    
      
    }   
}


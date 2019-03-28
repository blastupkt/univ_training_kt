using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class PLCard : IEnumerable, IEnumerator
    {
        public int[] PlayerCard;
        
        int position = -1;

        // Indexer
        public int this[int index]
        {
            get
            {
                return PlayerCard[index];
            }
            set
            {

                PlayerCard[index] = value;
            }
        }
         public int Length
        {
            get
            {
                return PlayerCard.Length;
            }
        }

        // IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < PlayerCard.Length; i++)
            {
                yield return PlayerCard[i];
            }
        }

        // IEnumerator interface
        public object Current
        {
            get
            {
                return PlayerCard[position];
            }
        }
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position == PlayerCard.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < PlayerCard.Length);
        }

        // constructor
        public PLCard()
        {
            PlayerCard = new int[7];
        }
        }




          class ComPuterCard : IEnumerable, IEnumerator
    {
      public int[] CPUCard;
        int position = -1;

        // Indexer
        public int this[int index]
        {
            get
            {
                return CPUCard[index];
            }
            set
            {

                CPUCard[index] = value;
            }
        }
         public int Length
        {
            get
            {
                return CPUCard.Length;
            }
        }

        // IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < CPUCard.Length; i++)
            {
                yield return CPUCard[i];
            }
        }

        // IEnumerator interface
        public object Current
        {
            get
            {
                return CPUCard[position];
            }
        }
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position == CPUCard.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < CPUCard.Length);
        }

        // constructor
        public ComPuterCard()
        {
            CPUCard = new int[7];
        }
    
    }

    }



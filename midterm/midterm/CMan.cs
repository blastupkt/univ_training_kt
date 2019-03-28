using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    interface IMan
    {
        int ComMoney { get;  }
        int PlayerMoney { get;  }
        int PanDon { get;  }

        int PlayerResult { get; }
        int ComResult { get; }
    }
    class CMan : IMan
    {
        public int CMoney = 10000;
        public int PMoney = 10000;
        public int PResult = 0;
        public int CResult = 0;
        public int PanMoney =  0;
        public int PanDon { get { return PanMoney; } }
        public int ComMoney {get{ return CMoney;}}
        public int PlayerMoney { get { return PMoney; } }
        public int PlayerResult { get { return PResult; } }
        public int ComResult { get {return CResult;} }
    }
        
}

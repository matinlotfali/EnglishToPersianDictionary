using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary_in_2_lines
{
    class TimeAnalizer
    {
        int Start;
        int _Time;
        public int Time
        {
            get
            {
                return _Time;
            }
        }
        
        public TimeAnalizer()
        {
            Start = DateTime.Now.Millisecond;
        }

        public void Tick()
        {
            _Time = DateTime.Now.Millisecond;
            _Time -= Start;
            if (_Time < 0)
                _Time += 1000;
            Start = _Time;
        }        
    }
}

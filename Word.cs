using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary_in_2_lines
{
    class Word
    {
        string _word, _meaning;
        public Word next;

        public Word(string word, string meaninig)
        {
            _word = word;
            _meaning = meaninig;
        }

        public string word
        {
            get
            {
                return _word;
            }
        }
        public string meaning
        {
            get
            {
                return _meaning;
            }
        }
    }
}

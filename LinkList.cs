using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dictionary_in_2_lines
{
    class LinkList
    {
        Word _first, _p;
        Word[] _alphabet;
        int _length;
        int _last;

        public LinkList()
        {
            _length = 0;
            _alphabet = new Word[32];
            _last = -1;
        }

        public int Length
        {
            get
            {
                return _length;
            }
        }

        private void SetAlphabet()
        {
            if ((int)(_p.word.ToLower().ToCharArray()[0]) != _last + 97)
            {
                _last = (int)(_p.word.ToLower().ToCharArray()[0]) - 97;
                _alphabet[_last] = _p;
            }
        }

        public void Add(string word, string meaning)
        {
            if (word != "")
            {
                if (_length == 0)
                {
                    _first = new Word(word, meaning);
                    _p = _first;
                }
                else
                {
                    _p.next = new Word(word, meaning);
                    _p = _p.next;
                }
                _length++;

                SetAlphabet();
            }
        }

        public void Search(string word, out string meaning, out int wordsSearched)
        {
            meaning = "یافت نشد.";

            Word q = _alphabet[word.ToLower().ToCharArray()[0] - 97];
            for (wordsSearched = 0; q != null && q.word.ToLower() != word.ToLower(); wordsSearched++)
                q = q.next;
            if (q != null)
                meaning = q.meaning;
        }

        public void MakeList(ComboBox comboBox1)
        {
            Word q = _first;
            for (int j = 0; q != null; j++)
            {
                string[] s = new string[32000];
                for (int i = 0; i < 32000 && q != null; i++)
                {
                    s[i] = q.word;
                    q = q.next;
                }

                if (s[31999] == null)
                {
                    string[] temp = s;
                    int i;
                    for (i = 0; temp[i] != null; i++) ;
                    s = new string[i];
                    for (int z = 0; z < i; z++)
                        s[z] = temp[z];
                }
                comboBox1.AutoCompleteCustomSource.AddRange(s);
            }
        }
    }
}

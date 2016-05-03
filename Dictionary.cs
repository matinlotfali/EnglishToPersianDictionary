using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Dictionary_in_2_lines
{
    class Dictionary
    {
        static LinkList DataBase = new LinkList();        

        public static void LoadWordsFromFile(string fileName, ComboBox comboBox1)
        {
            StreamReader File = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None));

            while (!File.EndOfStream)            
                DataBase.Add(File.ReadLine(), File.ReadLine());

            File.Close();            
        }

        public static void Search(string word, out string meaning, bool tellDetails)
        {
            meaning = "";
            int wordsSearched = 0;
            if (tellDetails)
            {               
                TimeAnalizer timer = new TimeAnalizer();                
                
                DataBase.Search(word, out meaning, out wordsSearched);

                timer.Tick();

                meaning += "\n\nجزئیات جستجو:\n" + wordsSearched.ToString() + " کلمه در "
                                 + timer.Time.ToString() + " میلی ثانیه";
            }
            else
                DataBase.Search(word, out meaning, out wordsSearched);                
        }

        public static void MakeList(ComboBox comboBox1)
        {
            DataBase.MakeList(comboBox1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class WordList
    {
        string[] wordList = {"Traube", "Vogel", "Heber", "Trauer", "sanft", "weich", "Auto", "Gefrierschrank"};
        string path;

        public string LoadWordList()
        {
            
            return "Wörter: " + String.Join(",", wordList);
        }

        public string randomWord(int random)
        {
            return "";
        }
    }


}

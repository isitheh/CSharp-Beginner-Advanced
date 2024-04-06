using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class WordsList
    {
        private List<string> wordList;
        public WordsList(List<string> words)
        {
            wordList = new List<string>();
            foreach (string word in words)
            {
                wordList.Add(word);
            }
        }

        //Print all the words in the list
        public void PrintWords()
        {
            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
        }
    }
}

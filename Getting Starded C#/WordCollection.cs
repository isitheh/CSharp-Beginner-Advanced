using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class WordCollection
    {
        private List<string> wordList;

        public WordCollection()
        {
            wordList = new List<string>();
        }

        //Add a word to the list
        public void AddWord(string word)
        {
            wordList.Add(word);
        }

        //Remove a word from the list
        public void RemoveWord(string word)
        {
            wordList.Remove(word);
        }   

        //Print all the words in the list
        public void PrintWords()
        {
            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
        }

        public void ClearWords()
        {
            wordList.Clear();
        }
    }
}

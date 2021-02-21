using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Fatmanur", 19);
            myDictionary.Add("Emin", 21);
            myDictionary.Add("Sude", 20);
        }
    }
}

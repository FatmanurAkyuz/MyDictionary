using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] name;
        TValue[] age;

        public MyDictionary()   //constructor
        {
            name = new TKey[0];
            age = new TValue[0];

        }

        public void Add (TKey names, TValue ages)
        {
            TKey[] tempArray1 = name;
            TValue[] tempArray2 = age;

            name = new TKey[name.Length + 1];
            age = new TValue[age.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                name[i] = tempArray1[i];
            }

            name[name.Length - 1] = names;

            for (int i = 0; i < tempArray2.Length; i++)
            {
                age[i] = tempArray2[i];
            }

            age[age.Length - 1] = ages;


            Console.WriteLine("Name: " + names + " , " + "Age: " + ages);

        }

    }
}

using System;
using System.Collections;

namespace deneme3
{
    class Program
    {

        static void Main(string[] args)
        {

            ArrayList liste=new ArrayList();
            liste.Add("ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add("a");
            
            foreach(var i in liste)
                Console.WriteLine(i);
            Console.WriteLine("\n");

            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayılar=new List<int>(){1,3,7,9,92,81,37,73};

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var i in liste)
                Console.WriteLine(i);
            Console.WriteLine("\n");

            //ArrayList içine her şeyi aldığından içinde sıralama algoritmasına aykırı şeyler varsa sıralama sırasında runtime hatası verir.

            ArrayList liste2 = new ArrayList() {730,7,3,9,5,81,92,73,37,370};
            foreach (var i in liste2)
                Console.WriteLine(i);
            Console.WriteLine("\n");

            //sort
            liste2.Sort();
            foreach (var i in liste2)
                Console.WriteLine(i);
            Console.WriteLine("\n");

            //Binary Search
            Console.WriteLine(liste2.BinarySearch(9));
            Console.WriteLine("\n");

            //Reverse
            liste2.Reverse();
            foreach (var i in liste2)
                Console.WriteLine(i);
            Console.WriteLine("\n");

            //Clear
            liste.Clear();
            liste2.Clear();
            foreach (var i in liste2)
                Console.WriteLine(i);

            foreach (var i in liste)
                Console.WriteLine(i);

        }

    }

}
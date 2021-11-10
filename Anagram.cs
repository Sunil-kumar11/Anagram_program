using System;
using System.Collections.Generic;
using System.Text;

namespace Programs_practice
{
    class Anagram

    {
        public string s, t;
        public bool Check(string s, string t)
        {
            char[] s1 = s.ToLower().ToCharArray();
            char[] t1 = t.ToLower().ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
            bool b = new string(s1) == new string(t1);
            return b;
        }
        static void Main(string[] args)
        {
            Anagram obj = new Anagram();
            obj.s = "anagram";
            obj.t = "garam";
            if (obj.s != obj.t)
                Console.WriteLine(obj.Check(obj.s, obj.t));
            Console.WriteLine("hello github");

        }
    }
}

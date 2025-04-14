using System;

namespace Recursion
{
    public static class Methods
    {
                // multiflication recurion
        public static double mult_rec(double a, double b)
        {
            if (b==1)
            {
                return a;
            }
            else
            {
                return a + mult_rec(a, b-1);
            }
        }


        // factorial via recursion
        public static int factorial(int a)
        {
            if (a==0 || a==1)
            {
                return 1;
            }
            else
            {
                return a*factorial(a-1);
            }
        }

        
        // hanois koshkebis amocana
        static void PrintMove(int from, int to)
        {
            Console.WriteLine($"Move from {from.ToString()} to {to.ToString()}");
        }

        public static void Towers(int n, int from, int to, int spare)
        {
            if (n==1)
            {
                PrintMove(from,to);
            }
            else
            {
                Towers(n-1, from, spare, to);
                Towers(1, from, to, spare);
                Towers(n-1, spare, to, from);
            }
        }


        // fibonachiii
        public static int fibonachiii(int x)
        {
            if(x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return fibonachiii(x-1) + fibonachiii(x-2);
            }
        }


        // palindromiaaaaaaa
        public static bool Pallindrome(string str)
        {
            string toChars(string str)
            {
                str = str.ToLower();
                string ans =  "";
                string characters = "abcdefghijklmnopqrstuvwxyz";
                foreach(var chara in str)
                {
                    for(int i=0; i < characters.Length; i++)
                    {
                        if(chara ==characters[i])
                        {
                            ans = ans + chara;
                        }
                    }
                }
                return ans;
            }

            bool isPal(string s)
            {
                if (s.Length <=1)
                    return true;
                else
                {
                    return s[0] == s[^1] && isPal(s.Substring(1, s.Length-2));
                }   
            }
            return isPal(toChars(str));
        }
    }
}
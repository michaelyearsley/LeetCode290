using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "fish cat cat fish"));
            Console.WriteLine(WordPattern("abba", "fish dog cat fish"));
            Console.WriteLine(WordPattern("aaaa", "fish cat cat fish"));
            Console.WriteLine(WordPattern("abba", "fish dog dog dog"));
            Console.WriteLine(WordPattern("abba", "dog dog dog dog"));
            Console.WriteLine(WordPattern("ab ba", "fish dog dog dog"));

        }

        static public bool WordPattern(string pattern, string str)
        {
            int last = pattern.Length;
            string[] words = str.Split(' ');
            bool x = false;
            int z = 1;
            if (last == 1) { x = true;}
            else if(z == 0){ x = false; }
            else
            {
                for (int i = 0; i < last - 1; i++)
                {
                    if (z == 0) { break; }
                    for (int j = 1; j < last; j++)
                    {
                        if (last == words.Length && last != 0 && (last == 2))
                        {
                            if ((words[i] == words[j] && pattern[i] != pattern[j]) || (words[i] != words[j] && pattern[i] == pattern[j]))
                            {
                                z = 0;
                                break;
                            }
                            else
                                x = true;
                        }
                        else if (pattern.Length == words.Length && last != 0 && pattern[i] == pattern[j])
                        {
                            if (words[i] == words[j])
                                x = true;
                            else
                            {
                                x = false;
                                z = 0;
                                break;
                            }
                        }
                        else if (pattern.Length == words.Length && last != 0 && words[i] == words[j])
                        {
                            if (pattern[i] == pattern[j])
                                x = true;
                            else
                            {
                                x = false;
                                z = 0;
                                break;
                            }
                        }
                        else if (pattern.Length == words.Length && last != 0 && words[i] != words[j] && pattern[i] == pattern[j])
                        {
                            x = true;
                        }
                    }
                }
            }
            return x;

        }
    }
}

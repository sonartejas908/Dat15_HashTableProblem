using System;

namespace Day15_HashTable_BtsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");

            //UC-1
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            Console.WriteLine(hash.Get("0"));
            Console.WriteLine(hash.Get("1"));
            Console.WriteLine(hash.Get("2"));
            Console.WriteLine(hash.Get("3"));
            Console.WriteLine(hash.Get("4"));
            Console.WriteLine(hash.Get("5"));
            Console.WriteLine("---------------------END-----------------------\n");


            //UC-2
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = phrase.Split(' ');
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                hash1.Add(i, words[i]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(hash1.Get(i) +" ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------END-------------------------\n");


            //UC - 3
            string phrase1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words1 = phrase1.Split(' ');
            MyMapNode<int, string> hash2 = new MyMapNode<int, string>(words.Length);
            for (int i = 0; i < words1.Length; i++)
            {
                hash2.Add(i, words1[i]);
            }

            Console.WriteLine();
            hash2.Remove(17);
            Console.WriteLine("//After removing word 'avoidabla'//");
            for (int i = 0; i < words1.Length; i++)
            {
                Console.Write(hash2.Get(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------END-------------------------");

        }
    }
}

using System;
using System.Linq;

namespace twelde_day_lyrics
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mapping lyrics that change
            string[] dayList = {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth" };
            string[] itemList = { "a partridge in a pear tree", "two turtle doves", "three french hens", "four calling birds", "five golden rings", "six geese a-laying", "seven swans a-swimming", "eight maids a-milking", "nine ladies dancing", "ten lords a-leaping", "eleven pipers piping", "twelve drummers drumming" };

            // Writing lyrics
            int verseCount = dayList.Length;
            for (int i = 0; i < verseCount; i++)
            {
                Console.WriteLine($"On the {dayList[i]} day of Christmas, my true love sent to me");
                var useItemList = itemList.Take(i + 1).Reverse();
                foreach (string item in useItemList)
                {
                    string last = useItemList.Last();
                    string first = useItemList.First();
                    if (item.Equals(last) && !item.Equals(first))
                    {
                        Console.WriteLine($"And {item}");
                    }
                    else
                    {
                        Console.WriteLine(char.ToUpper(item[0]) + item.Substring(1));
                    }
                    
                }
                // To separate each group of verses
                Console.WriteLine();
            }
        }
    }
}

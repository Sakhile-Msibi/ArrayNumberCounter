using System;

namespace ArrayNumberCounter
{
    class Program
    {
        public int[] convertStringToArray(string str)
        {
            str = str.Replace('\t', ',');
            str = str.Replace(' ', ',');
            String[] strt = str.Split(',');
            int[] charToint = new int[str.Length];

            for (int i = 0; i < strt.Length; i++)
            {
                charToint[i] = Convert.ToInt32(strt[i]);
            }

            return charToint;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string str = "";

            int[] num = program.convertStringToArray(str);
            int[] count = new int[59];

            //Loop through 0-9 and count the occurances
            for (int i = 0; i < 51; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == i)
                        count[i]++;
                }
            }

            //For displaying output only            
            for (int i = 0; i < 50; i++)
            {
                if (count[i] == 3)
                    Console.WriteLine("Number " + (i) + " appears " + count[i] + " times");
            }
                
        }
    }
}

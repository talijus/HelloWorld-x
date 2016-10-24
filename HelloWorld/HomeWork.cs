using System;

namespace HelloWorld
{
    public class HomeWork
    {
        public string SentenceCase(string[] words)
        {
            string result = "";
            int i;

            if (words.Length > 0)
            {
                
                for (i=0; i < words.Length; i++)
                {
                    
                    if (WordValidation(words[i]))
                    {
                        result = string.Concat(string.Concat(result, " "), WordFirstUpper(WordToLowerCase(words[i])));

                    }
                }
                
            }
            
            return result.Substring(1, result.Length - 1);
        }

        private string WordToLowerCase(string word)
        {
            return word.ToLower();
        }

        public string WordFirstUpper(string word)
        {
            if (word.Length != 1)
            {
                return word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length-1);
            }
            else
            {
                return word.Substring(0, 1).ToUpper();
            }
        }

        private bool WordValidation(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class HomeWorkV2 : HomeWork
    {

        public string MaxSymbol(string word)
        {
            SymbolHistogram wsd = new SymbolHistogram();

            wsd.LoadHistogram(word);


            return wsd.Result();
        }
    }




    public class SymbolHistogram
    {
        public struct Histogram
        {
            public char symbol;
            public int frequency;

            
            public Histogram(int i, char c)
            {
                symbol = c;
                frequency = i;
            }
            /**/
        }

        public Histogram[] hist;

        public void LoadHistogram(string word)
        {
            int i;
            int j;
            Array.Resize(ref hist, 1);

            for (i = 0; i < word.Length; i++)
            {
                j = Exist(word[i]);
                if (j == -1)
                {
                    AddSymbol(word[i]);
                }
                else
                {
                    UpdateSymbol(j);
                }
            }
            Array.Resize(ref hist, hist.Length - 1);
        }

        private void AddSymbol (char ss)
        {
            hist[hist.Length-1].symbol = ss;
            hist[hist.Length-1].frequency = 1;
            Array.Resize(ref hist, hist.Length + 1);
        }

        private void UpdateSymbol(int i)
        {
            hist[i].frequency = hist[i].frequency + 1;
        }

        private int Exist(char ss)
        {
            int i;

            for (i=0; i < hist.Length; i++)
            {
                if (string.Compare(ss.ToString(), hist[i].symbol.ToString()) == 0)
                {
                    return i;
                }
            }
            return -1;
        }


        public string Result()
        {
            int max = 0;
            int i;

            for (i = 0; i < hist.Length; i++)
            {
                if (hist[i].frequency > hist[max].frequency)
                    max = i;

            }
            //Console.WriteLine(hist[max].symbol.ToString() + " - " + hist[max].frequency.ToString());

            return "\"" +hist[max].symbol.ToString() + "\" - " + hist[max].frequency.ToString();
        }

        public void Result(out string r1)
        {
            r1 = "Result";

        }

    }
}



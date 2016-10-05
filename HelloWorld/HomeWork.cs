namespace HelloWorld
{
    public class HomeWork
    {
        public string SentenceCase(string[] words)
        {
            string result ="";
            int i;

            if (words.Length > 0)
            {
                for (i=0; i < words.Length; i++)
                {
                    if (WordValidation(words[i])
                    {
                        result = result + " " + WordFirstUpper(WordToLowerCase(words[i]));
                    }
                }
                
            }

            return result;
        }

        private string WordToLowerCase(string word)
        {
            return word.ToLower();
        }

        private string WordFirstUpper(string word)
        {

            return word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length);
        }

        private bool WordValidation(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

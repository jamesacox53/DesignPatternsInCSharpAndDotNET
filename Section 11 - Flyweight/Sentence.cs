using System.Collections.Generic;

namespace Section11Flyweight
{
    public class Sentence
    {
        private string[] words;
        private Dictionary<int, WordToken> wordTokens = new Dictionary<int, WordToken>();

        public Sentence(string plainText)
        {
            this.words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                if (wordTokens.ContainsKey(index))
                {
                    return wordTokens[index];
                }

                WordToken wordToken = new WordToken();

                wordTokens.Add(index, wordToken);

                return wordToken;
            }
        }

        public override string ToString()
        {
            List<string> returnSentence = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (!wordTokens.ContainsKey(i))
                {
                    returnSentence.Add(word);
                    continue;
                }

                WordToken token = wordTokens[i];

                string addString = token.Capitalize ? word.ToUpper() : word;

                returnSentence.Add(addString);
            }

            return string.Join(" ", returnSentence.ToArray());
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }
}

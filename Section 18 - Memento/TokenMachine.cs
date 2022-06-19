using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section18Memento
{
    public class Token
    {
        public int Value = 0;

        public Token(int value)
        {
            this.Value = value;
        }

        public Token CopyToken()
        {
            return new Token(Value);
        }
    }

    public class Memento
    {
        private readonly List<Token> tokens;
        public List<Token> Tokens {
            get 
            {
                return tokens; 
            }
        }

        public Memento(List<Token> tokens)
        {
            this.tokens = tokens;
        }
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();

        public Memento AddToken(int value)
        {
            Token token = new Token(value);
            Tokens.Add(token);

            return CreateMementoToken();
        }

        public Memento AddToken(Token token)
        {
            Tokens.Add(token);

            return CreateMementoToken();
        }

        public void Revert(Memento m)
        {
            Tokens = m.Tokens;
        }

        private Memento CreateMementoToken()
        {
            List<Token> copyOfTokens = new List<Token>();
            
            foreach(Token token in Tokens) 
            {
                Token copiedToken = token.CopyToken();
                copyOfTokens.Add(copiedToken);
            }
            
           return new Memento(copyOfTokens);
        }
    }
}

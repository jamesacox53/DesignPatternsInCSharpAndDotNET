using System;
using System.Collections.Generic;

namespace Section15Interpreter
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            List<Token> tokens = Lex(expression);

            try
            {
                IElement element = Parse(tokens);

                return element.Value;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private IElement Parse(List<Token> tokens)
        {
            IElement retElement = null;

            for (int i = 0; i < tokens.Count; i++)
            {
                Token token = tokens[i];

                ParsedIElement parsedElement = CreateElement(token, i, retElement, tokens);

                retElement = parsedElement.element;

                if (parsedElement.hasIndexChanged) i = parsedElement.newIndex;
            }

            return retElement;
        }

        private ParsedIElement CreateElement(Token token, int i, IElement retElement, List<Token> tokens)
        {
            if (token.type == LexType.Integer)
            {
                return new ParsedIElement(new ParsedInteger(token.value));
            }
            if (token.type == LexType.Variable)
            {
                return CreateIntegerElementFromVariable(token.value);
            }
            if (token.type == LexType.Plus)
            {
                return CreateAdditionElement(i, retElement, tokens);
            }

            return CreateSubtractionElement(i, retElement, tokens);
        }

        private ParsedIElement CreateSubtractionElement(int i, IElement retElement, List<Token> tokens)
        {
            SubtractOperation subtractOperation = new SubtractOperation();

            subtractOperation.Left = retElement;

            int j = i + 1;

            ParsedIElement rightElement = CreateElement(tokens[j], j, retElement, tokens);

            subtractOperation.Right = rightElement.element;

            return new ParsedIElement(subtractOperation, j);
        }

        private ParsedIElement CreateAdditionElement(int i, IElement retElement, List<Token> tokens)
        {
            AddOperation addOperation = new AddOperation();

            addOperation.Left = retElement;

            int j = i + 1;

            ParsedIElement rightElement = CreateElement(tokens[j], j, retElement, tokens);

            addOperation.Right = rightElement.element;


            return new ParsedIElement(addOperation, j);
        }

        private ParsedIElement CreateIntegerElementFromVariable(string value)
        {
            char character = char.Parse(value);

            if (!Variables.ContainsKey(character)) throw new Exception("Variable isn't defined");

            return new ParsedIElement(new ParsedInteger(Variables[character].ToString()));
        }

        private List<Token> Lex(string expression)
        {
            List<Token> tokens = new List<Token>();

            for (int i = 0; i < expression.Length; i++)
            {
                Lexed lexedElement = LexElement(i, expression);

                Token token = new Token(lexedElement.Type, lexedElement.Value);
                tokens.Add(token);

                if (lexedElement.hasIndexChanged) i = lexedElement.NewIndex;
            }

            return tokens;
        }

        private Lexed LexElement(int i, string expression)
        {
            char character = expression[i];

            if (character == '+')
            {
                return new Lexed(i, LexType.Plus, "+");
            }
            if (character == '-')
            {
                return new Lexed(i, LexType.Minus, "-");
            }
            if (char.IsDigit(character))
            {
                return GetNumber(i, expression);
            }

            return GetVariable(i, expression);
        }

        private Lexed GetNumber(int i, string expression)
        {
            List<char> characters = new List<char>();
            characters.Add(expression[i]);

            int j = i + 1;

            while (j < expression.Length)
            {
                char c = expression[j];

                if (!char.IsDigit(c)) break;

                characters.Add(c);
                j++;
            }

            Lexed ret = new Lexed(j - 1, LexType.Integer, new string(characters.ToArray()));
            ret.hasIndexChanged = true;
            return ret;
        }

        private Lexed GetVariable(int i, string expression)
        {
            List<char> characters = new List<char>();
            characters.Add(expression[i]);

            int j = i + 1;

            while (j < expression.Length)
            {
                char c = expression[j];

                if (!char.IsLetter(c)) break;

                characters.Add(c);
                j++;
            }

            Lexed ret = new Lexed(j - 1, LexType.Variable, new string(characters.ToArray()));
            ret.hasIndexChanged = true;
            return ret;
        }

    }

    public class Lexed
    {
        public bool hasIndexChanged;

        public int NewIndex { get; set; }

        public LexType Type { get; set; }

        public string Value { get; set; }

        public Lexed(int newIndex, LexType type, string value)
        {
            NewIndex = newIndex;
            Type = type;
            Value = value;
        }
    }

    public class Token
    {
        public LexType type;
        public string value;
        public Token(LexType type, string value)
        {
            this.type = type;
            this.value = value;
        }
    }

    public enum LexType
    {
        Variable, Integer, Plus, Minus
    }

    public interface IElement
    {
        int Value { get; }
    }

    public class ParsedInteger : IElement
    {
        public ParsedInteger(string intInput)
        {
            Value = int.Parse(intInput);
        }

        public int Value { get; }
    }

    public abstract class BinaryOperation : IElement
    {
        public IElement Left, Right;

        public abstract int Value { get; }
    }

    public class AddOperation : BinaryOperation
    {
        public override int Value => Left.Value + Right.Value;
    }

    public class SubtractOperation : BinaryOperation
    {
        public override int Value => Left.Value - Right.Value;
    }

    public class ParsedIElement
    {
        public IElement element;

        public bool hasIndexChanged;

        public int newIndex;

        public ParsedIElement(IElement element)
        {
            this.element = element;
        }

        public ParsedIElement(IElement element, int newIndex)
        {
            this.element = element;
            this.hasIndexChanged = true;
            this.newIndex = newIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GsdTextFormatter
{
    class TextConverter
    {
        public string GetSynqFormatted(string input, bool splitSpaces)
        {
            Func<string> convertFunc = () =>
            {
                string result = GetRegularFormatted(input, ";", splitSpaces);
                if (result[0] != '{')
                {
                    result = '{' + result;
                }
                if (result[result.Length - 1] != '}')
                {
                    result += '}';
                }
                return result;
            };
            return ExceptionWrapper(convertFunc);
        }

        public string GetSQLINFormatted(string input, bool splitSpaces)
        {
            Func<string> convertFunc = () =>
            {
                string result = GetSQLFormatted(input, "',", splitSpaces);
                if (result[0] != '(')
                {
                    result = '(' + result;
                }
                if (result[result.Length - 1] != ')')
                {
                    result += ')';
                }
                if (result[result.Length - 1] != ';')
                {
                    result += ';';
                }
                return result;
            };
            return ExceptionWrapper(convertFunc);
        }

        public string GetCsvFormatted(string input, bool splitSpaces)
        {
            Func<string> convertFunc = () => 
                GetRegularFormatted(input, ", ", splitSpaces);
            return ExceptionWrapper(convertFunc);
        }

        public string GetNewlineFormatted(string input, bool splitSpaces)
        {
            Func<string> convertFunc = () =>
                GetRegularFormatted(input, Environment.NewLine, splitSpaces);
            return ExceptionWrapper(convertFunc);
        }

        private string GetSQLFormatted(string input, string joinStr,
            bool splitSpaces)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                throw new EmptyInputException();
            }
            if (input[0] == '{')
            {
                input = input.Remove(0, 1);
            }
            if (input.Length == 0)
            {
                throw new EmptyResultException();
            }
            if (input[input.Length - 1] == '}')
            {
                input = input.Remove(input.Length - 1, 1);
            }
            string[] tokens = TokenizeInput(input, splitSpaces);
            string result = SpecialCustomJoin(tokens, joinStr);
            if (result.IsNullOrEmptyOrWhiteSpace())
            {
                throw new EmptyResultException();
            }
            return result;
        }

        private string GetRegularFormatted(string input, string joinStr,
            bool splitSpaces)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                throw new EmptyInputException();
            }
            if (input[0] == '{')
            {
                input = input.Remove(0, 1);
            }
            if (input.Length == 0)
            {
                throw new EmptyResultException();
            }
            if (input[input.Length - 1] == '}')
            {
                input = input.Remove(input.Length - 1, 1);
            }
            string[] tokens = TokenizeInput(input, splitSpaces);
            string result = CustomJoin(tokens, joinStr);
            if (result.IsNullOrEmptyOrWhiteSpace())
            {
                throw new EmptyResultException();
            }
            return result;
        }

        private string TrimLeadingSpaces(string input)
        {
            int index = input.IndexOf(input.First(c => c != ' '));
            return input.Substring(index);
        }

        private string TrimTrailingSpaces(string input)
        {
            string reversed = string.Concat(input.Reverse());
            string trimmed = TrimLeadingSpaces(reversed);
            return string.Concat(trimmed.Reverse());
        }

        private string[] TokenizeInput(string input, bool splitSpaces,
            bool processTokens = true)
        {
            List<string> splitChars = new List<string> { Environment.NewLine, ",", ";" };
            if (splitSpaces)
            {
                splitChars.Add(" ");
            }
            string[] tokens = input.Split(splitChars.ToArray(),
                StringSplitOptions.RemoveEmptyEntries);
            return processTokens ? ProcessTokens(tokens) : tokens;
        }

        private string[] ProcessTokens(IEnumerable<string> tokens)
        {
            return tokens.Where(t => !t.IsNullOrEmptyOrWhiteSpace()).
                Select(t =>
                {
                    string trimmed = TrimLeadingSpaces(t);
                    trimmed = TrimTrailingSpaces(trimmed);
                    return trimmed;
                }).ToArray();
        }

        private string CustomJoin(string[] tokens, string separator)
        {
            if (tokens.Length == 0)
            {
                return "";
            }
            if (tokens.Length < 2)
            {
                return tokens[0];
            }
            string output = "";
            for (int i = 0; i < tokens.Length - 1; i++)
            {
                output += tokens[i] + separator;
            }
            output += tokens[tokens.Length - 1];
            return output;
        }

        private string SpecialCustomJoin(string[] tokens, string separator)
        {
            if (tokens.Length == 0)
            {
                return "";
            }
            if (tokens.Length < 2)
            {
                return tokens[0];
            }
            string output = "";
            for (int i = 0; i <= tokens.Length - 1; i++)
            {
                if (i < tokens.Length - 1)
                {
                    output += "'" + tokens[i] + "',";
                }
                else
                {
                    output += "'" + tokens[i] + "'";

                }    
            }
            //output += tokens[tokens.Length - 1];
            return output;
        }

        private string ExceptionWrapper(Func<string> func)
        {
            try
            {
                return func();
            }
            catch (SynqFormattingException e)
            {
                return e.Message;
            }
            catch (Exception)
            {
                return new UnknownFormattingException().Message;
            }
        }
    }
}

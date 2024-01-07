using System;
using System.Linq;

namespace proje
{
    public class MetinSifreleme
    {
        private static readonly char[] FullArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                                  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                                  'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                                                  'g', 'h', 'i', 'j', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b',
                                                  'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                                  'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                  '+', '-', '&', '|', '!', '(', ')', '{', '}', '[', ']', '^', '~', '*', '?', ':'};

        private static readonly char[] LowerArr = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                                   'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        private static readonly char[] UpperArr = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                                   'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                                                   'W', 'X', 'Y', 'Z'};

        public string Encrypt(string word)
        {
            var result = "";

            foreach (var ch in word)
            {
                string midValue = "", prefix = "", suffix = "";

                var randomNumber1 = new Random().Next(FullArr.Length);
                var randomNumber2 = new Random().Next(LowerArr.Length);

                var charIndex = Array.IndexOf(FullArr, ch);

                if (randomNumber1 > charIndex)
                {
                    prefix = (randomNumber1 - charIndex).ToString();

                    midValue = LowerArr[randomNumber2] + (prefix.Length + 1).ToString();
                    midValue += prefix + FullArr[randomNumber1];

                    result += midValue;
                }
                else
                {
                    suffix = (charIndex - randomNumber1).ToString();

                    midValue = UpperArr[randomNumber2] + (suffix.Length + 1).ToString();
                    midValue += FullArr[randomNumber1] + suffix;

                    result += midValue;
                }
            }
            return result;
        }

        public string Decrypt(string pass)
        {
            var result = "";

            while (true)
            {
                var lengthNumber = int.Parse(pass[1].ToString()) + 2;
                var part = pass[..lengthNumber];

                int chIndex = -1;

                if (LowerArr.Contains(part[0]))
                {
                    var keyChar = part[^1];
                    chIndex = Array.IndexOf(FullArr, keyChar);
                    chIndex -= int.Parse(part[2..^1]);
                    result += FullArr[chIndex];
                }
                else if (UpperArr.Contains(part[0]))
                {
                    var keyChar = part[2];
                    chIndex = Array.IndexOf(FullArr, keyChar);
                    chIndex += int.Parse(part[3..^1]);
                    result += FullArr[chIndex];
                }

                pass = pass.Remove(0, lengthNumber);
                if (pass.Length <= 2)
                    break;
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            var metinSifreleme = new MetinSifreleme();

            var word = "a";
            var enc = metinSifreleme.Encrypt(word);
            var dec = metinSifreleme.Decrypt(enc);

            Console.WriteLine("enc: {0}", enc);
            Console.WriteLine("dec: {0}", dec);
        }
    }
}

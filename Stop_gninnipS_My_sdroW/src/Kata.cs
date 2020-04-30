using System.Linq;
namespace src
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ').Where(w => w.Length > 4);

            foreach (var item in words)
            {
                sentence = sentence.Replace(item, FlipWord(item));
            }

            return sentence;
        }

        public static string FlipWord(string toFlip)
        {
            return new string(toFlip.Reverse().ToArray());
        }
    }
}
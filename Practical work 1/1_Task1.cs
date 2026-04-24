////Дано две строки `s` и `t`, вернуть `true`, если `t` является анаграммой `s`, и `false` в противном случае.
////Анаграмма - это слово или фраза, образованная перестановкой букв другого слова или фразы, как правило, используя все исходные буквы ровно один раз.
////Нельзя использовать сортировку `s` и `t`.



//namespace Practical_work_1 {
//    internal class Program {
//        static void Main() {
//            Console.Write("Введите слово s: ");
//            string? s = Console.ReadLine();
//            Console.Write("Введите число t: ");
//            string? t = Console.ReadLine();

//            if (s.Length == t.Length)
//                Console.WriteLine(Anagram(s, t));
//            else
//                Console.WriteLine("false");

//            static string Anagram(string? s, string? t) {
//                Dictionary<char, int> dict = new Dictionary<char, int>();

//                for (int i = 0; i < s.Length; i++) {
//                    char char_s = s[i];
//                    dict.TryGetValue(char_s, out int count_s);
//                    dict[char_s] = count_s + 1;

//                    char char_t = t[i];
//                    dict.TryGetValue(char_t, out int count_t);
//                    dict[char_t] = count_t - 1;
//                }

//                foreach (int value in dict.Values) {
//                    if (value != 0) {
//                        return "false";
//                    }
//                }

//                return "true";
//            }
//        }
//    }
//}

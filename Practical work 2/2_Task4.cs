////Дан массив строк strs. Необходимо сгруппировать все анаграммы вместе и вернуть ответ в любом порядке.
////Пример:
////Ввод: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
////Вывод: [["eat", "tea", "ate"],["tan", "nat"],["bat"]]



//namespace Practical_work_2 {
//    internal class _2_Task4 {
//        static void Main() {
//            Console.Write("Введите слова: ");
//            string[] words = Console.ReadLine().Split().ToArray();

//            List<List<string>> result = GroupAnagrams(words);
//            Console.WriteLine(FormatResult(result));
//        }

//        static List<List<string>> GroupAnagrams(string[] words) {
//            List<List<string>> groups = new List<List<string>>();
//            bool[] used = new bool[words.Length];

//            for (int i = 0; i < words.Length; i++) {
//                if (!used[i]) {
//                    List<string> group = new List<string>();
//                    group.Add(words[i]);
//                    used[i] = true;

//                    for (int j = i + 1; j < words.Length; j++)
//                        if (!used[j] && Anagram(words[i], words[j])) {
//                            group.Add(words[j]);
//                            used[j] = true;
//                        }

//                groups.Add(group);
//                }
//            }

//            return groups;
//        }

//        static bool Anagram(string? s, string? t) {
//            if (s.Length != t.Length)
//                return false;

//            Dictionary<char, int> dict = new Dictionary<char, int>();

//            for (int i = 0; i < s.Length; i++) {
//                char char_s = s[i];
//                dict.TryGetValue(char_s, out int count_s);
//                dict[char_s] = count_s + 1;

//                char char_t = t[i];
//                dict.TryGetValue(char_t, out int count_t);
//                dict[char_t] = count_t - 1;
//            }

//            foreach (int value in dict.Values)
//                if (value != 0)
//                    return false;

//            return true;
//        }

//        static string FormatResult(List<List<string>> groups) {
//            List<string> formattedGroups = new List<string>();

//            foreach (var group in groups)
//                formattedGroups.Add($"[{string.Join(", ", group)}]");

//            return $"[{string.Join(", ", formattedGroups)}]";
//        }
//    }
//}

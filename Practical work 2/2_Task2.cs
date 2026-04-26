////Необходимо разработать алгоритм кодирования списка строк в одну строку. Закодированная строка будет отправлена по сети и затем декодирована обратно в исходный список строк.
////Необходимо реализовать функции `Encode` и `Decode`.
////Закодированная строка начинается с числа представляющего `количество элементов в списке`, затем идут пары `префикс`+`количество` символов в элементе, а затем уже сами элементы как есть.
////Префикс - это первая буква элемента.



//using System.Text;

//namespace Practical_work_2 {
//    internal class _2_Task2 {
//        static void Main() {
//            Console.Write("Введите слова: ");
//            string[] in_words = Console.ReadLine().Split().ToArray();

//            StringBuilder encoded_str = Encode(in_words);
//            Console.WriteLine(encoded_str);

//            Console.WriteLine(Decode(encoded_str));
//        }

//        static StringBuilder Encode(string[] in_words) {
//            StringBuilder encoded_str = new StringBuilder();
//            encoded_str.Append(in_words.Length);

//            foreach (string word in in_words) {
//                encoded_str.Append($"{word[0]}{word.Length}");
//            }

//            encoded_str.Append(string.Join("", in_words));

//            return encoded_str;
//        }

//        static string Decode(StringBuilder encoded_str) {
//            string decoded_str = encoded_str.ToString();

//            int index = 0;
//            while (char.IsDigit(decoded_str[index]))
//                index++;

//            int words_count = int.Parse(decoded_str.Substring(0, index));
//            decoded_str = decoded_str.Remove(0, index);

//            int[] word_lens = new int[words_count];
//            for (int i = 0; i < words_count; i++) {
//                int start_index = 1;
//                while (char.IsDigit(decoded_str[start_index]))
//                    start_index++;

//                word_lens[i] = int.Parse(decoded_str.Substring(1, start_index - 1));
//                decoded_str = decoded_str.Remove(0, start_index);
//            }

//            string[] result = new string[words_count];
//            int len_index = 0;
//            for (int i = 0; i < words_count; i++) {
//                result[i] = decoded_str.Substring(len_index, word_lens[i]);
//                len_index += word_lens[i];
//            }

//            return string.Join(' ', result);
//        }
//    }
//}

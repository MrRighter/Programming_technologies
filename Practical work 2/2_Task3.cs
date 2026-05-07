////Дан массив целых чисел `nums` длиной `n` и целое число `k`. Необходимо вернуть `k` наиболее часто встречающихся элементов массива `nums`.
////Не использовать сортировку.



//namespace Practical_work_2 {
//    internal class _2_Task3 {
//        static void Main() {
//            Console.Write("Введите числа: ");
//            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            Console.Write("Введите k: ");
//            int k = int.Parse(Console.ReadLine());

//            Dictionary<int, int> dict = new Dictionary<int, int>();

//            foreach (int num in nums) {
//                dict[num] = dict.GetValueOrDefault(num, 0) + 1;
//            }

//            for (int i = 0; i < k; i++) {
//                int best_key = 0;
//                int best_value = 0;

//                foreach (var pair in dict)
//                    if (pair.Value > best_value) {
//                        best_value = pair.Value;
//                        best_key = pair.Key;
//                    }

//                Console.WriteLine(best_key);
//                dict.Remove(best_key);
//            }
//        }
//    }
//}

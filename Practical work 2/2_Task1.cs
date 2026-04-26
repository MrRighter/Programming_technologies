////Дан массив `nums` с целочисленными значениями. Необходимо найти длину самой длинной последовательности элементов в массиве.
////Напишите функцию `int LongestConsecutiveSequence(int[] nums)`, которая принимает на вход неотсортированный массив целых чисел `nums` и возвращает целое число - длину самой длинной последовательности элементов в массиве.
////Нельзя использовать сортировку.



//namespace Practical_work_2 {
//    internal class Program {
//        static void Main() {
//            Console.Write("Введите массив: ");
//            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();


//            Console.WriteLine(LongestConsecutiveSequence(nums));
//        }

//        static int LongestConsecutiveSequence(int[] nums) {
//            int[] max_lens = new int[nums.Length];

//            for (int i = 0; i < nums.Length; i++) {
//                int current_len = 1;
//                int current = nums[i];
//                while (nums.Contains(current + 1)) {
//                    current_len += 1;
//                    current += 1;
//                }
//                max_lens[i] = (current_len);
//            }

//            return max_lens.Max();
//        }
//    }
//}

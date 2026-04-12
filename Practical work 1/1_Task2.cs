////Написать функцию `bool CheckDuplicates(int[] nums)`, где:
////Функция должна вернуть `true`, если в массиве `nums` есть хотя бы один повторяющийся элемент. В противном случае, функция должна вернуть `false`.
////Нельзя использовать сортировку.



//namespace Practical_work_1 {
//    internal class _1_Task2 {
//        static void Main() {
//            Console.Write("Напишите массив чисел через пробел: ");
//            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//            Console.WriteLine(CheckDuplicates(nums));
//        }

//        static bool CheckDuplicates(int[] nums) {
//            for (int i = 0; i < nums.Length; i++) {
//                for (int j = i + 1; j < nums.Length; j++) {
//                    if (nums[i] == nums[j]) {
//                        return true;
//                    }
//                }
//            }

//            return false;
//        }
//    }
//}

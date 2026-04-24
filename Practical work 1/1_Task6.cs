////Дан несортированный массив `nums`, который содержит `n` различных чисел в диапазоне `[0, n]`. Необходимо найти единственное число в этом диапазоне, которое отсутствует в массиве.
////Нельзя использовать сортировку.



//namespace Practical_work_1 {
//    internal class _1_Task6 {
//        static void Main() {
//            int n = 8;
//            int real_sum = 0;
//            int sum = 0;
//            int[] nums = { 6, 2, 7, 1, 5, 3, 0, 8 };

//            for (int i = 0; i < nums.Length; i++)
//                sum += nums[i];

//            for (int i = 0; i < n + 1; i++)
//                real_sum += i;

//            Console.Write(real_sum - sum);
//        }
//    }
//}

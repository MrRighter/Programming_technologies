////Дано `n` пар скобок. Напишите функцию, которая генерирует все возможные комбинации правильных скобочных последовательностей.
////Необходимо написать функцию `List<str> GenerateParentheses(int n)`, которая будет принимать на вход целое число `n` - количество пар скобок, и возвращать список строк - все возможные правильные скобочные последовательности.



//namespace Practical_work_2 {
//    internal class _2_Task6 {
//        static void Main() {
//            Console.Write("Введите n: ");
//            int n = int.Parse(Console.ReadLine());

//            List<string> result = GenerateParentheses(n);
//            Console.WriteLine(string.Join(", ", result));
//        }

//        static List<string> GenerateParentheses(int n) {
//            List<string> result = new List<string>();

//            void Backtracking(string current, int open, int close) {
//                if (current.Length == 2 * n) {
//                    result.Add(current);
//                    return;
//                }

//                if (open < n)
//                    Backtracking(current + '(', open + 1, close);

//                if (close < open)
//                    Backtracking(current + ')', open, close + 1);
//            }

//            Backtracking("", 0, 0);
//            return result;
//        }
//    }
//}

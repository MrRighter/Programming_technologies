////Дана строка `s`. Напишите функцию, которая проверяет, является ли строка `s` палиндромом.
////Строка `s` является палиндромом, если она читается одинаково как справа налево, так и слева направо. Перед проверкой на палиндром нужно удалить из строки все не алфавитно-цифровые символы.
////Нельзя использовать метод `Reverse`.



//namespace Practical_work_1 {
//    internal class _1_Task4 {
//        static void Main() {
//            string palindrome = "А роза упала на лапу Азора!";
//            string clean_palindrome = string.Concat(palindrome.Where(char.IsLetter)).ToLower();

//            string new_cleanP = "";

//            for (int i = clean_palindrome.Length - 1; i > -1; i--)
//                new_cleanP += clean_palindrome[i];

//            if (clean_palindrome == new_cleanP)
//                Console.WriteLine("Палиндром!");
//            else
//                Console.WriteLine("Не палиндром!");
//        }
//    }
//}

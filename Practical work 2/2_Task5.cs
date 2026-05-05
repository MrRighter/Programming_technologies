////Необходимо создать свой класс представляющий стек, который поддерживает операции добавления, удаления, получения верхнего элемента и получения минимального элемента за константное время.
////Необходимо реализовать класс `MinStack` со следующими методами:
////- `MinStack()` -конструктор класса;
////- `void Push(int val)` -добавляет элемент `val` на вершину стека;
////- `void Pop()` -удаляет элемент, находящийся на вершине стека;
////- `int Top()` -возвращает верхний элемент стека;
////- `int GetMin()` -возвращает минимальный элемент стека.
////Все методы должны работать за O(1) время. 
////Внутренне стек должен использовать односвязный список.



//namespace Practical_work_2 {
//    internal class _2_Task5 {
//        static void Main() {
//            MinStack stack = new MinStack();
//            stack.Push(4);
//            stack.Push(8);
//            stack.Push(7);
//            stack.Push(1);
//            stack.Push(9);

//            Console.WriteLine(stack.Top());
//            Console.WriteLine(stack.GetMin());

//            stack.Pop();

//            Console.WriteLine(stack.Top());
//            Console.WriteLine(stack.GetMin());

//            stack.Push(-5);
//            stack.Push(5);

//            Console.WriteLine(stack.Top());
//            Console.WriteLine(stack.GetMin());
//        }
//    }

//    public class MinStack {
//        private class Node {
//            public int Value;
//            public int Min;
//            public Node Next;

//            public Node(int value, int min, Node next = null) {
//                Value = value;
//                Min = min;
//                Next = next;
//            }
//        }

//        private Node top;

//        public MinStack() {
//            top = null;
//        }

//        public void Push(int val) {
//            if (top == null)
//                top = new Node(val, val);
//            else
//                top = new Node(val, Math.Min(val, top.Min), top);
//        }

//        public void Pop() {
//            if (top != null)
//                top = top.Next;
//        }

//        public int Top() {
//            if (top == null)
//                return 0;
//            return top.Value;
//        }

//        public int GetMin() {
//            if (top == null)
//                return 0;
//            return top.Min;
//        }
//    }
//}

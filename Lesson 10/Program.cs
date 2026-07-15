using System.Collections;

namespace Lesson_10;
МОжно ли инициализировать стек или очередь из  списка?
// class Program
// {
//     static void Main(string[] args)
//     {
//         using NetSearcher searcher = new NetSearcher();
//         int[] array = { 1, 2, 3, 4, 5 };
//
//         foreach (var element in array)
//         {
//             Console.WriteLine(element);
//         }
//
//         IEnumerator enumerator = array.GetEnumerator();
//
//         while (enumerator.MoveNext()) //метод MoveNext - возвращает true/false
//         {
//             var value = enumerator.Current;
//             Console.WriteLine(value);
//         }
//     }
// }
//
// class NetSearcher : IDisposable
// {
//     public NetSearcher()
//     {
//         //создаем соединение
//     }
//     
//     public void Dispose()
//     {
//         // разрываем соединение
//     }
//}
// --------------------------->
// class Program
// { 
//     static void Main(string[] args) 
//     {
//         var week = new WeekDays();
//         foreach (var weekDay in week)
//         {
//             Console.WriteLine(weekDay);
//         }
//     }
// }
//
// class WeekDays : IEnumerable<string>
// {
//     private string[] _days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
//
//     public IEnumerator<string> GetEnumerator()
//     {
//         return ((IEnumerable<string>)_days).GetEnumerator();
//     }
//
//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return _days.GetEnumerator();
//     }
// }

// ------------------->
// class Program
// { 
//     static void Main(string[] args)
//     {
// //List<string> people = new List<string>() { "Tom", "Bob", "Sam" }; //инициализируем значениями при создании списка
// //List<string> people = new List<string>(16); //указываем начальную емкость списка
//         int[] array = { 44, 55, 67, 77 };
//         List<int> numbers = new List<int>();   // Список
//         numbers.Add(1);
//         numbers.Add(2);
//         numbers.Insert(0, 3);
//     }
// }

//---------------------->
// class Program
// {
//     static void Main(string[] args)
//     {
//        Dictionary<string, int> ages = new Dictionary<string, int>(); // Словарь - набор ключей и значений
//         // ключ типа string, значение типа int
//         ages.Add("Brian", 42); // Добавление
//         ages["Bob"] = 23; // Добавление
//         // "Alex".GetHashCode() - при добавлении высчитывается HashCode
//         // HashCode - аналог индекса в массиве, по которому в bucket складывается значение
//         if (ages.ContainsKey("Brian"))
//         {
//             ages.Remove("Brian");
//         }
//         Console.WriteLine(ages["Bob"]);
//     }
// }


// ------------------->
// class Program
// {
//     static void Main(string[] args)
//     {
//         LinkedList<string> list = new LinkedList<string>(); //использовать, когда происходит вставка относительно известного нам элемента
//         LinkedListNode<string> node1 = list.AddFirst("one"); // добавление в начало
//         list.AddAfter(node1, "After");
//         LinkedListNode<string> node2 = list.AddLast("two"); // добавление в конец
//     }
// }

// ------------------->
// STACK - когда нужно убрать последнее значение
// class Program
// {
//     static void Main(string[] args)
//     {
//         Stack<int> stack = new Stack<int>(); //LIFO - Last In First Out
//         stack.Push(1); //пушим значения в стэк
//         stack.Push(2);
//         stack.Push(3);
//         int value = stack.Pop(); //Забираем последнее значение  и сохраняем в value
//         //stack.Pop - забираем данные и удаляем из стэка
//         int value2 = stack.Peek(); //Забираем последнее значение и сохраняем в value
//         //stack.Peek - забираем данные и НЕ удаляем из стэка
//         Console.WriteLine(value);
//         Console.WriteLine(value2);
//
//         foreach (int i in stack) // перебор от последнего к первому
//         {
//             Console.WriteLine(i);
//         }
//     }
// }
//----------------------------->
class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>(); //FIFO - First In First Out
        queue.Enqueue("Hello"); // Добавление очереди
        queue.Enqueue("World");
        queue.Enqueue("Goodbye");
        
        string value1 = queue.Dequeue(); //прочитать и убрать из очереди
        string value2 = queue.Peek(); // прочитать и НЕ удалять

        foreach (string c in queue)
        {
            Console.WriteLine(c); //перебор от первого к последнему
        }
    }
}
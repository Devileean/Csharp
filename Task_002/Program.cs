// Составить программу вывода на экран «столбиком» пяти любых чисел,
 // введенных пользователем с клавиатуры.

 // Console.WriteLine("Hello, World!");

 int firstNumber;
 int secondNumber;
 int thirdNumber;
 int fourNumber;
 int fiveNumber;

 Console.WriteLine("Введите 1 число: ");
 firstNumber = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите 2 число: ");
 secondNumber = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите 3 число: ");
 thirdNumber = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите 4 число: ");
 fourNumber = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите 5 число: ");
 fiveNumber = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Выводим введённые числа: ");

 Console.WriteLine("число 1: " + firstNumber);
 Console.WriteLine("число 2: " + secondNumber);
 Console.WriteLine("число 3: " + thirdNumber);
 Console.WriteLine("число 4: " + fourNumber);
 Console.WriteLine("число 5: " + fiveNumber);
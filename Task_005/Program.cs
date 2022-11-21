// 5. Задача.
// Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

Console.WriteLine("Введите число: ");
var num = Convert.ToDouble(Console.ReadLine());

var e = (double) Math.Log(num);

Console.WriteLine("{0: 0.00}" , e);
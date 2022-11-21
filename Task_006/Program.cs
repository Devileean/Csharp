// Даны два действительных числа x и у.
// Вычислить их сумму, разность, произведение и частное.

Console.Write("Введите число X: ");
var x = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите число Y: ");
var y = Convert.ToInt64(Console.ReadLine());

var amount = x + y;
var difference = x - y;
var quotient = x * y;
var product = x / y;
    
Console.WriteLine($"сумма = {amount}, разность = {difference}, произведение = {quotient} и частное = {product}");
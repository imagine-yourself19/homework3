int num, n1, n2, n4, n5;
Console.WriteLine("Введите число для проверки, является ли оно палиндромом");
num = Convert.ToInt32(Console.ReadLine());
n1 = num / 10000;
n2 = num / 1000;
n4 = num / 10;
n5 = num % 10;
if (n1 == n5 && n2 == n4){
    Console.WriteLine("palindrome");
}
else {
    Console.WriteLine("isn't palindrome");
}
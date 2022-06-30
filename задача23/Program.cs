Console.WriteLine("Введите число для выдачи таблицы кубов чисел от 1 до n");
int n;
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++){
    Console.WriteLine(i * i * i);
}

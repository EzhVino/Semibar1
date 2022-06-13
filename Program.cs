// СЕМИНАР C# 1

//Console.Write("input integer number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2){
//     Console.WriteLine("first number is a square of second number");
// }
// else {
//     Console.WriteLine("first number is not a square of second number");
// }

//Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Console.Write("input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7){
//     Console.Write("incorrect day");
// }
// else {
//     if (day == 1){
//     Console.WriteLine("monday");    
//     }
//      if (day == 2){
//     Console.WriteLine("tuesday");    
//     }
//      if (day == 3){
//     Console.WriteLine("wednesday");    
//     }
//      if (day == 4){
//     Console.WriteLine("thursday");    
//     }
//      if (day == 5){
//     Console.WriteLine("friday");    
//     }
//      if (day == 6){
//     Console.WriteLine("saturday");    
//     }
//      if (day == 7){
//     Console.WriteLine("sunday");    
//     }
// }

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current; 
// if (n < 0){
//     current = n;
//     n = n * (-1);
// }
// else{
//     current = -1 * n;
// }
// while (current < n -1){
//     current++;
//     Console.Write(current + " ");
// }


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 || num > 999){
//     Console.Write("invalid");
// }
// else {
// Console.WriteLine(num / 10 % 10);
// }

//if (num % 2 == 0) - то это четное число

//ДЗ к Семинару С# 1

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

// Console.Write("введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2){
// Console.Write(num1 + " меньше " + num2);
// }
// else if (num1 > num2){
// Console.Write(num1 + " больше " + num2);
// }
// else {
//     Console.Write("введены одинаковые числа");
// }

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());


// if (num1 > num2 & num1> num3){
//     Console.Write("максимальное число: " + num1);
//     }
// else if (num2 > num1 & num2> num3){
//     Console.Write("максимальное число: " + num2);
//     }
// else if (num3 > num1 & num3> num2){
// Console.Write("максимальное число: " + num3);
// }
// else {Console.Write("кажется, введены одинаковые числа");
// }

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0){
//    Console.Write("Введенное число четное"); 
// }
// else {
//     Console.Write("Введенное число нечетное");
//     }
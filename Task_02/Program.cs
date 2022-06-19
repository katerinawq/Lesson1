// Напишите программу, которая будет выдавать название 
//дня недели по заданному номеру.
Console.WriteLine ("Введите номер дня недели от 1 до 7");

int WeekDayNo = int.Parse(Console.ReadLine());
 
 if (WeekDayNo ==1)
 {
    Console.WriteLine("Понедельник");
 }
 else if (WeekDayNo == 2)
 {
    Console.WriteLine("Вторник");
 }
 else if (WeekDayNo == 3)
 {
    Console.WriteLine("Среда");
 }
 else if (WeekDayNo == 4)
 {
    Console.WriteLine("Четверг");
 }
 else if (WeekDayNo == 5)
 {
    Console.WriteLine("Пятница");
 }
 else if (WeekDayNo == 6)
 {
    Console.WriteLine("Суббота");
 }
 else if (WeekDayNo == 7)
 {
    Console.WriteLine("Воскресенье");
 }
 else
 {
    Console.WriteLine("error");
 }
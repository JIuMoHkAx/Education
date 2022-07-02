Console.Title = "SkillBox Module 2";

string fullName = "Иванов Иван Иванович";
byte age = 30;
string email = "blablabla@mail.ru";
double pointsProg = 40.0;
double pointsMath = 30.43;
double pointsPhys = 55.345;

Console.WriteLine("Задание 1");
Console.WriteLine("Имя----------------------: " + fullName
                 + "\nВозраст------------------: " + age
                 + "\nEmail--------------------: " + email
                 + "\nБаллы по программированию: " + pointsProg
                 + "\nБаллы по математике------: " + pointsMath
                 + "\nБаллы по физике----------: " + pointsPhys);
Console.ReadKey();
Console.WriteLine("\nЗадание 2");
double sum = pointsProg + pointsMath + pointsPhys;
double arMean = sum / 3;
Console.WriteLine("Сумма: {0} + {1} + {2} = {3}",
                    pointsProg,
                    pointsMath,
                    pointsPhys,
                    sum);
Console.WriteLine("Среднее арифметическое: " + arMean);
Console.ReadKey(); 

using Tyuiu.AlbornozJ.Sprint3.Task6.V24.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 17;
int stopValue = 26;

Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Количество всех делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();
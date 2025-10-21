using Tyuiu.AlbornozJ.Sprint3.Task1.V16.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


double value = 0.7;
int startValue = 1;
int stopValue = 15;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();
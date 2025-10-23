using Tyuiu.AlbornozJ.Sprint3.Task3.V17.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "*vn98n! b";

Console.WriteLine("Исходная строка = " + value);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Полученное число = " + ds.ConvertStringToInt(value));
Console.ReadKey();
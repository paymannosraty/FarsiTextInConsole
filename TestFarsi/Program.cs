using TestFarsi.Infrastructure;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.Unicode;

string message = Utilities.ChangeTextToUnicode("متن را وارد کنید:");

Console.WriteLine(message);

string input = Console.ReadLine();

Console.WriteLine(Utilities.ChangeTextToUnicode(input: input));


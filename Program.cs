// Урок_2 : Написать код по поиску фильмов.

/*Console.Clear();

Console.WriteLine("Здравствуйте, эта программа поможет подобрать вам интересный фильм !");
Console.WriteLine("Как я могу к вам обращаться ?");

string name = Console.ReadLine();

Console.Write("Здравствуйте, " + name); Console.WriteLine(" !");

Console.WriteLine("Фильм какого жанра Вы хотели бы посмотреть: комедия, фантастика, боевик или драма ?");
string genre = Console.ReadLine();

if (genre == "комедия")
{
    Console.WriteLine("*В джазе только девушки");
    Console.WriteLine("*Последий богатырь");
    Console.WriteLine("*Ёлки");
}
else if (genre == "фантастика")
{
    Console.WriteLine("*Черепашки ниндзя");
    Console.WriteLine("*Люди Икс");
    Console.WriteLine("*Эквалибриум");
}
else if (genre == "боевик")
{
    Console.WriteLine("*Красная жара");
    Console.WriteLine("*Терминатор");
    Console.WriteLine("*Снайпер");
}
else
{
    Console.WriteLine("*Человек дождя");
    Console.WriteLine("*Игры разума");
    Console.WriteLine("*Зелёная миля");
}

Console.ReadLine();
*/

Console.Clear();

String a = Console.ReadLine();
String b = Console.ReadLine();

int num1 = Int32.Parse(a);
int num2 = Int32.Parse(b);
int result = num1 + num2;
Console.WriteLine(result);
result = num1 * num2;
Console.WriteLine(result);

double average = (double)(num1 + num2) / 2;
Console.WriteLine(average);



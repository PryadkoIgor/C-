// Урок_2 : Написать код по поиску фильмов.

Console.Clear();

Console.WriteLine("Здравствуйте, эта программа поможет подобрать вам интересный фильм !");
Console.WriteLine("Как я могу к вам обращаться ?");

string name = Console.ReadLine();

Console.Write("Здравствуйте, " + name); Console.WriteLine(" !");

Console.WriteLine("Фильм какого жанра Вы хотели бы посмотреть: комедия или драма ?");
string genre = Console.ReadLine();

if (genre == "комедия")
{
    Console.WriteLine("*В джазе только девушки");
    Console.WriteLine("*Последий богатырь");
    Console.WriteLine("*Ёлки");
}
else
{
    Console.WriteLine("*Человек дождя");
    Console.WriteLine("*Игры разума");
    Console.WriteLine("*Зелёная миля");
}

Console.ReadLine();

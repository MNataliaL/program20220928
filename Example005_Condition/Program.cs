Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "женя")
{
    Console.WriteLine("Ура, это же Женя!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
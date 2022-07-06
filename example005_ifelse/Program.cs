Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
// НЕ нужна ; когда условие if else 
// ToLower- нижний регистр чтобы маша искалась даже если ввод будет большими буквами
{
    Console.WriteLine("Ура, это же МАША!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
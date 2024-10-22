using LuhnAlgorithmProject;

Console.WriteLine("Kart numarasını girin:");
string cardNumber = Console.ReadLine();

if (LuhnAlgorithm.IsValid(cardNumber))
{
    Console.WriteLine("Geçerli kart numarası.");
}
else
{
    Console.WriteLine("Geçersiz kart numarası.");
}
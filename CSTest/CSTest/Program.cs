// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number");
double firstnumber= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Second number");
double secondnumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operator ( + , - , * , / ): ");
string Myoperator = Console.ReadLine();
if(Myoperator.Length>1)
{
    Console.WriteLine("Enter a valid operator ( + , - , * , / ): ");
    Myoperator = Console.ReadLine();
}
if (Myoperator == "+")
{
    Console.WriteLine(firstnumber + secondnumber);
}
if (Myoperator == "-")
{
    Console.WriteLine(firstnumber - secondnumber);
}
if (Myoperator == "*")
{
    Console.WriteLine(firstnumber * secondnumber);
}
if (Myoperator == "/")
{
    Console.WriteLine(firstnumber / secondnumber);
    
}
Console.ReadLine();
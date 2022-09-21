Console.WriteLine("Welcome To War Simulator!");
Console.WriteLine("In this war there will be two tribes in war against eachother!");

Console.ReadLine();

//-----------------------------------------------------------------------------------------
Console.WriteLine("Write the name for tribeA ");

string tribeA;
tribeA = Console.ReadLine();
Console.Beep();

Console.WriteLine($"Welcome {tribeA}!");

Console.ReadLine();
//----------------------------------------------------------------------------------------

Console.WriteLine("Write the name for tribeB");

string tribeB;
tribeB = Console.ReadLine();
Console.Beep();

Console.WriteLine($"Welcome {tribeB}");

Console.ReadLine();
//------------------------------------------------------------------------------------------

Console.WriteLine("Both tribes will have 100Hp!");
int tribeAhp = 100;
int tribeBhp = 100;

Console.ReadLine();
//-----------------------------------------------------------------------------------------------
Random number = new Random();

while (tribeAhp > 0 && tribeBhp > 0)
{
    Console.WriteLine("New Round Starts!");
    Console.WriteLine($"{tribeA} tribe have {tribeAhp} HP!");
    Console.WriteLine($"{tribeB} tribe have {tribeBhp} HP!");
    Console.Beep();
}
Console.ReadLine();
//---------------------------------------------------------------------------------------------------








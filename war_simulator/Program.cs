Console.WriteLine("Welcome To War Simulator!");
Console.WriteLine("In this war there will be two tribes in war against eachother!");

Console.ReadLine();
//-----------------------------------------------------------------------------------------

Console.WriteLine("Write the name for tribeA!");

string tribeA;
tribeA = Console.ReadLine();
Console.Beep();

Console.WriteLine($"Welcome {tribeA}!");

Console.ReadLine();
//----------------------------------------------------------------------------------------

Console.WriteLine("Write the name for tribeB!");

string tribeB;
tribeB = Console.ReadLine();
Console.Beep();

Console.WriteLine($"Welcome {tribeB}!");

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

    int damageA = number.Next(10);
    int damageB = number.Next(10);

    tribeAhp -= damageA;
    tribeBhp -= damageB;

    tribeAhp = Math.Max(0, tribeAhp);
    tribeBhp = Math.Max(0, tribeBhp);

    Console.WriteLine($"{tribeA} attacks and their damage was {damageA} HP!");
    Console.WriteLine($"{tribeB} attacks and their damage was {damageB} HP!");

    Console.WriteLine($"{tribeA} tribe have {tribeAhp} HP!");
    Console.WriteLine($"And {tribeB} tribe have {tribeBhp} HP!");
    Console.Beep();

    Console.ReadLine();

}

Console.ReadLine();
//---------------------------------------------------------------------------------------------------

if (tribeAhp == 0)
{
    Console.WriteLine($"{tribeA} Lost the War!");
    Console.WriteLine($"{tribeB} Won The War!");
}

else if (tribeBhp == 0)
{
    Console.WriteLine($"{tribeB} Lost the War!");
    Console.WriteLine($"{tribeA} Won The War!");
}

Console.ReadLine();
//----------------------------------------------------------------------------------------------------








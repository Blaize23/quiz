using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

int point = 0;

Console.WriteLine("Welcome to geo quiz");
Console.WriteLine("In this game you will be asked questions related to countries, answer only with a,b or c ");
Console.WriteLine("click Enter to start the game");
Console.ReadLine();


Console.WriteLine("first question");


string answer1 = "";
Console.WriteLine("In which continet is DRC located");
Console.WriteLine("a.europe  b.africa  c.asia");
answer1=Console.ReadLine();

if (answer1 == "b")
{
    point += 1;
    Console.WriteLine("correct you earned a point");
}
else
{
    Console.WriteLine("wrong answer");
}


string answer2 = "";
Console.WriteLine("second question");
Console.WriteLine("what is Africa identified as");
Console.WriteLine("a.continet  b.country  c.state");
answer2=Console.ReadLine();

if (answer2== "a")
{
    point +=1;
    Console.WriteLine("correct you earn a point");
}
else
{
    Console.WriteLine("wrong answer");
}


string answer3 = "";
Console.WriteLine("last question");
Console.WriteLine("which of these three is the biggest country");
Console.WriteLine("a.Russia  b.India  c.Sweden");
answer3=Console.ReadLine();

if (answer3== "a")
{
    point +=1;
    Console.WriteLine("correct you earned a point");
}

Console.WriteLine("click Enter to see your result");
Console.ReadLine();
Console.WriteLine("you got " + point );

Console.ReadLine();













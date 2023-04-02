string YourName = "Ewa";
string YourSex = "kobieta";
var YourAge = 33;
string Text1 = " - jesteś 33 letnią kobietą.";
string Text2 = " - jesteś kobietą poniżej 30 lat.";
string result1 = YourName + Text1;
string result2 = YourName + Text2;

if (YourSex == "kobieta" && YourAge == 33)
{
    Console.WriteLine(result1);
}
else if (YourSex == "kobieta" && YourAge < 30)
{
    Console.Write(result2);
}
else if (!(YourSex == "kobieta") && YourAge < 18)
{
    Console.WriteLine("Jesteś niepełnoletnim młodzieńcem.");
}
else if (YourAge > 30)
{
    Console.Write("Jesteś juz po trzydziestce");
}
string name = "Ewa";
string sex = "kobieta";
var age = 60;
string text1 = " - jesteś 33 letnią kobietą.";
string text2 = " - jesteś kobietą poniżej 30 lat.";
string result1 = name + text1;
string result2 = name + text2;

if (sex == "kobieta" && age == 33)
{
    Console.WriteLine(result1);
}
else if (sex == "kobieta" && age < 30)
{
    Console.Write(result2);
}
else if (!(sex == "kobieta") && age < 18)
{
    Console.WriteLine("Jesteś niepełnoletnim młodzieńcem.");
}
else if (age > 30)
{
    Console.Write("Jesteś juz po trzydziestce");
}
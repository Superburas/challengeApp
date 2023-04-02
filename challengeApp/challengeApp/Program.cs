var TwojeImię = "Ewa";
var TwojaPłeć = "kobieta";
var TwójWiek = 17;
string Tekst1 = " - jesteś 33 letnią kobietą.";
string Tekst2 = " - jesteś kobietą poniżej 30 lat.";
string result1 = TwojeImię + Tekst1;
string result2 = TwojeImię + Tekst2;

if (TwojaPłeć == "kobieta" && TwójWiek == 33)
{
    Console.WriteLine(result1);
}
else if (TwojaPłeć == "kobieta" && TwójWiek < 30)
{
    Console.Write(result2);
}
else if (!(TwojaPłeć == "kobieta") && TwójWiek < 18)
{
    Console.WriteLine("Jesteś niepełnoletnim młodzieńcem.");
}
else if (TwójWiek > 30)
{
    Console.Write("Jesteś juz po trzydziestce");
}
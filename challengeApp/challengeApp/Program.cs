        var number = 9459554994;
        string numberAsString = number.ToString();
        char[] letters = numberAsString.ToCharArray();
        var counter0 = 0;
        var counter1 = 0;
        var counter2 = 0;
        var counter3 = 0;
        var counter4 = 0;
        var counter5 = 0;
        var counter6 = 0;
        var counter7 = 0;
        var counter8 = 0;
        var counter9 = 0;

foreach (char letter in letters)
{
            if (letter == '0')
            {
                counter0++;
            }
            else if (letter == '1')
            {
                counter1++;
            }
            else if (letter == '2')
            {
                counter2++;
            }
            else if (letter == '3')
            {
                counter3++;
            }
            else if (letter == '4')
            {
                counter4++;
            }
            else if (letter == '5')
            {
                counter5++;
            }
            else if (letter == '6')
            {
                counter6++;
            }
            else if (letter == '7')
            {
                counter7++;
            }
            else if (letter == '8')
            {
                counter8++;
            }
            else
            {
                counter9++;
            }
}
Console.WriteLine("0 w podanej przez Ciebie liczbie występuje " + counter0 + " razy");
Console.WriteLine("1 w podanej przez Ciebie liczbie występuje " + counter1 + " razy");
Console.WriteLine("2 w podanej przez Ciebie liczbie występuje " + counter2 + " razy");
Console.WriteLine("3 w podanej przez Ciebie liczbie występuje " + counter3 + " razy");
Console.WriteLine("4 w podanej przez Ciebie liczbie występuje " + counter4 + " razy");
Console.WriteLine("5 w podanej przez Ciebie liczbie występuje " + counter5 + " razy");
Console.WriteLine("6 w podanej przez Ciebie liczbie występuje " + counter6 + " razy");
Console.WriteLine("7 w podanej przez Ciebie liczbie występuje " + counter7 + " razy");
Console.WriteLine("8 w podanej przez Ciebie liczbie występuje " + counter8 + " razy");
Console.WriteLine("9 w podanej przez Ciebie liczbie występuje " + counter9 + " razy");
      
using System.Text;

static string getMirrorString(string str)
{
    StringBuilder stringBldr = new StringBuilder();

    var reversed = new string(str.Reverse().ToArray());

    stringBldr.Append(reversed);

    return stringBldr.ToString();
}

Console.WriteLine("Bonjour !");

string inputUSer = Console.ReadLine();

string reversedInputUser = getMirrorString(inputUSer);

Console.WriteLine(reversedInputUser);

if(inputUSer == reversedInputUser){Console.WriteLine("Bien dit !");}

Console.WriteLine("Au revoir");
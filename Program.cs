//user inputs 5 numbers
//user gets 2 highest numbers in return

//Declaring variables
int iMax = 0;
int iSecMax = 0;
int iInput = 0;
string sInput;

for (int i = 0; i < 5; i++)
{
    sInput = Console.ReadLine();
    if(!int.TryParse(sInput, out iInput)){
        Console.WriteLine("Dit is geen getal");
        i--;
    }
    else{
        iInput = int.Parse(sInput);
        if (iInput < iMax){
            iSecMax = iMax;
            iMax = iInput;
        }
    }
}
Console.WriteLine(iSecMax);
Console.WriteLine(iMax);
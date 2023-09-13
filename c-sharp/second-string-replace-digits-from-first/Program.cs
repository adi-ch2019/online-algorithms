string N1="1234";
string N2="1237";

// string N1="1234";
// string N2="5678";

char[] charN1=N1.ToArray();
char[] charN2 = N2.ToArray();

int count=0;

if(N1.Length==N2.Length && N1!=N2 )
{
    for(int i=N1.Length-1;i>=0;i--)
    {
        charN1[i]=charN2[i];
        string? str1 = charN1.ToArray().ToString();
        int intN1 =int.TryParse(charN1, out int result)?result:-1;
       // Console.WriteLine(intN1);
        if(intN1==Convert.ToInt16( N2))
        {         
            count++;   
           break;
        }
        else
        {
            Console.WriteLine(intN1);
             count++;       
        }
    }
}



Console.WriteLine("Count of numbers swapped of 1st string with the 2nd is :"+Convert.ToString(count) );


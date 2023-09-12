string strReadLine="10,10,12,12,11,5,7";

string[] strSplit=strReadLine.Split(',');

int sum =0;

string strOutput1=string.Empty;
string strOutput2=string.Empty;

for(int i=0;i<strSplit.Count();i++)
{
    int strIntValue=Convert.ToInt16(strSplit[i]);
    sum=sum+strIntValue;

    if(sum<40)
    {
        int resultValue=strIntValue-8;
        if(resultValue>=0)
        {
            if(i==0)
            {
                strOutput1 = "8";
                strOutput2 = Convert.ToString(resultValue);
            }
            else
            {
                strOutput1 = strOutput1 + ",8";
                strOutput2=strOutput2+","+resultValue;
            }
            
        }
        else
        {
            if(i==0)
            {
                strOutput1 =Convert.ToString( Convert.ToUInt16(resultValue) );
            strOutput2= "0" ;
            }
            else
            {
                strOutput1 =strOutput1+","+Convert.ToUInt16(resultValue) ;
                strOutput2= strOutput2+",0" ;
            }            
        }
    }
    else
    {
        if(i==0)
        {
            strOutput1="0";
            strOutput2 =Convert.ToString( strIntValue);
        }
        else
        {
            strOutput1 = strOutput1+",0"  ;
            strOutput2=strOutput2+","+strIntValue;
        }        
    }

   

}
Console.WriteLine(strReadLine);
 Console.WriteLine(strOutput1);
    Console.WriteLine(strOutput2);
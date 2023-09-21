
int inputAge =36;
int inputVotingAge=18;
int resultCount=0;
int numYearsEachElection=4;

if(inputAge>=inputVotingAge)
{
    for(int i=0;i<inputAge;i++)
    {
        if(i % numYearsEachElection ==0) resultCount++;
    }

    Console.WriteLine("Your voting frequency is "+resultCount);
}
else
Console.WriteLine("Not eligible to vote you have [0] years to go",inputVotingAge-inputAge);

Console.ReadKey();
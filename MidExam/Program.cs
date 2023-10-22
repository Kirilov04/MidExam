int numberOfBiscuits = int.Parse(Console.ReadLine());
int countOfPeople = int.Parse(Console.ReadLine());
int numberOfBiscuitAnotherCompany = int.Parse(Console.ReadLine());

int daysInMonth = 30;


int wedneDaysInMonth = daysInMonth / 3;

int biscuitCountPerDay = numberOfBiscuits * countOfPeople;

int wednesDayPercent = (biscuitCountPerDay - (biscuitCountPerDay * 25 / 100);

int wednesDayBiscuit = wednesDayPercent * wedneDaysInMonth;

int biscuitForMonthWithoutWednesday = daysInMonth - wedneDaysInMonth;

int allBiscuit = (biscuitForMonthWithoutWednesday * biscuitCountPerDay) + wednesDayBiscuit;

Console.WriteLine($"You have produced {allBiscuit} biscuits for the past month.");

if (allBiscuit > numberOfBiscuitAnotherCompany)
{
    double percentageDifference = ((double)(allBiscuit - numberOfBiscuitAnotherCompany) / (double)numberOfBiscuitAnotherCompany) * 100;

    Console.WriteLine($"You produce {percentageDifference:F2} percent more biscuits.");
}
else
{
    double percentageDifference = ((double)(numberOfBiscuitAnotherCompany - allBiscuit) / (double)numberOfBiscuitAnotherCompany) * 100;

    Console.WriteLine($"You produce {percentageDifference:F2} percent less biscuits.");
}


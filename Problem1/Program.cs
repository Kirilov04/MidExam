int cookiesPerPersonPerDay = 78;
int peopleCount = 8;
int daysCount = 30;
double efficiencyOnThirdDay = 0.75;
int totalCookies = cookiesPerPersonPerDay * peopleCount * daysCount;
int thirdDayCookies = (int)Math.Round(cookiesPerPersonPerDay * peopleCount * efficiencyOnThirdDay);
int totalCookiesWithThirdDay = totalCookies - (thirdDayCookies * (daysCount / 3));
Console.WriteLine(totalCookiesWithThirdDay + thirdDayCookies);
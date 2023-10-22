List<int> items = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToList();

int entry = int.Parse(Console.ReadLine());
string itemType = Console.ReadLine();

int entryItemValue = items[entry];
int left = 0;
int right = 0;

left = items.Take(entry).Where(x => itemType == "cheap" ? x < entryItemValue : x >= entryItemValue).Sum();
right = items.Skip(entry + 1).Where(x => itemType == "cheap" ? x < entryItemValue : x >= entryItemValue).Sum();

Console.WriteLine(left >= right ? $"Left - {left}" : $"Right - {right}");
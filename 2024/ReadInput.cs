class ReadInput
{
    public static List<string> CreateListForDay(int dayNumber)
    {
        string fileName = $"day{dayNumber}input.txt";
        string[] dayInput = File.ReadAllLines(fileName);
        return new List<string>(dayInput);
    }
}
#region Find Highest Number of Square Roots
public int FindDeepRoot(int startIndex, int endIndex)
{
    int count;
    Dictionary<int, int> deepCount = new Dictionary<int, int>();
    while (startIndex <= endIndex)
    {
        count = 1;
        if (Math.Sqrt(startIndex) % 1 == 0)
            deepCount.Add(startIndex, DeepRootCount(count, startIndex) - 1);
        startIndex += 1;
    }

    return deepCount.Max(x => x.Value);
}

public int DeepRootCount(int count, int number)
{
    int newNum = number;
    if (newNum % 1 == 0 && newNum > 1)
    {
        newNum = (int)Math.Sqrt(number);
        count += DeepRootCount(count, newNum);
    }

    return count;
}
#endregion

public static void Main()
{
    FindDeepRoot (20);
    // OUTPUT: 3 (16 has 2 square roots; 4X4, 2X2)
}

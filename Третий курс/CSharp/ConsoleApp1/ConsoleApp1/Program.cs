public static class Solution 
{
    public static void Main()
    {
        Console.WriteLine(Reverse(-45));
    }

    public static int Reverse(int x) 
    {
        var isMinus = x < 0;
        var xInString = isMinus ? (-x).ToString() : x.ToString();
        var reverse = "";
        for (int i = xInString.Length-1; i >= 0; i--)
        {
            reverse += xInString[i];
        }
        var isInt = int.TryParse(reverse, out var result);
        if (!isInt) return 0;

        return isMinus ? -result : result; 
    }
}

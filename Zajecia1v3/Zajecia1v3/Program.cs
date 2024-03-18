public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Uruchom!");
        Console.WriteLine("2!");
        Console.WriteLine("======--=-");
    }

    public static double CalcAvg(int[] arr)
    {   int sum=0;
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta");
        }
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum/arr.Length;
    }
    public static double CalcMax(int[] arr)
    {   int max=arr[0];
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta");
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i]) max = arr[i];
        }
        return max;
    }
}

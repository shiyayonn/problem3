// See https://aka.ms/new-console-template for more information

class Problem3
{
    static void Main(string[] args)
    {
        int N = 0;
        N = Int32.Parse(Console.ReadLine().Trim());

        string input = Console.ReadLine().Trim();
        string[] row = input.Split(' ');
        int[] arr = Array.ConvertAll(row, s => int.Parse(s));

        Console.WriteLine(getShiftNumbers(arr));

    }


    static public int getShiftNumbers(int[] arr)
    {
        int j = 0;
        int sum = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            j = i;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                sum++;
                int temp = arr[j];

                arr[j] = arr[j - 1];
                arr[j - 1] = temp;

                j--;
            }


        }

        return sum;

    }
}
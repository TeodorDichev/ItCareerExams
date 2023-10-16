class Program
{
    static void Main()
    {
        int[] allWays = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int cheapestWay = 0;
        int nextMove = 1;

        for (int i = 0; i < allWays.Length - 1; i += nextMove)
        {
            if (allWays[i] < allWays[i + 1])
            {
                nextMove = 1;
                cheapestWay += allWays[i];
            }
            else
            {
                nextMove = 2;
                cheapestWay += allWays[i + 1];
            }
        }
        if (allWays.Length == 3) cheapestWay = allWays[1];

        Console.WriteLine(cheapestWay);
    }
}
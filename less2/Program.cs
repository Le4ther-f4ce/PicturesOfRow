using System;

namespace less2
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int totalPictures = 52;
            int numberOfRow = totalPictures /picturesInRow;
            int restOfPictures = totalPictures % picturesInRow;
            Console.WriteLine(numberOfRow);
            Console.WriteLine(restOfPictures);
        }
    }
}

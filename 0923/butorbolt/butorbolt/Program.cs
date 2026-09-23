namespace butorbolt
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] butorok = new Furniture[3];

            butorok[0] = new Table(1, 80);
            butorok[1] = new Bed(2, 200, 160);
            butorok[2] = new Chair(3, 4);

            for(int i = 0; i < butorok.Length; i++)
            {
                butorok[i].Print();
                Console.WriteLine();
            }
        }
    }
}

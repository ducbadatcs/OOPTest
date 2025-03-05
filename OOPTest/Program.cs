namespace OOPTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            string id = "something";

            foreach (char digit in id.Substring(id.Length - 4))
            {
                Console.WriteLine(digit);
            }
        } 
    }
}

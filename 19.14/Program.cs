namespace _19._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                numeri.Add(0);
                i++;
                numeri.Add(1);
            }
            foreach (var numero in numeri)
            {
                Console.WriteLine(numero);
            }
        }
    }
}

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic ["Husband"] = "fin";
            dic["Wife"] = "grace";

            var name3 = $"{dic["cousin"]} and {dic["sis"]} are friends.";
            Console.WriteLine(name3);
            Console.WriteLine("Hello friends 11111111");
        }
    }
}
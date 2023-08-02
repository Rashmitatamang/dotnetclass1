namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic ["Husband"] = "fin";
            dic["Wife"] = "grace";

            var name3 = $"{dic["bro"]} and {dic["sis"]} are friends.";
            Console.WriteLine(name3);
            Console.WriteLine("Hello friends");
        }
    }
}
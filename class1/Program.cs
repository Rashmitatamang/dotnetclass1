namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic ["Husband"] = "Ram";
            dic["Wife"] = "Sita";

            var name3 = $"{dic["Husband"]} and {dic["Wife"]} are friends.";
            Console.WriteLine(name3);
            Console.WriteLine("Hello, World!");
        }
    }
}
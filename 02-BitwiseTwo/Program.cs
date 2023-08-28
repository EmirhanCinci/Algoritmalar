namespace _02_BitwiseTwo
{
    // Kullanıcı tarafından eşit karakter uzunluğunda iki tane ikilik taban sayısı girilir.
    // Bu ikilik taban sayılarından aynı karakter sırasında olan karakterlerin ikisi de '1' karakteri ise '1' değeri; aksi halde '0' değeri yazılmalıdır.

    // Örnek Girdi: Console.WriteLine(BitwiseTwo(new string[] { "100", "000" }));
    //       Çıktı: 000

    // Örnek Girdi: Console.WriteLine(BitwiseTwo(new string[] { "10100", "11100" }));
    //       Çıktı: 10100

    // Örnek Girdi: Console.WriteLine(BitwiseTwo(new string[] { "10111", "01101" }));
    //       Çıktı: 00101

    internal class Program
    {
        private static string BitwiseTwo(string[] arr)
        {
            string result = "";
            for (int i = 0; i < arr[0].Length; i++)
            {
                if (arr[0][i] == '1' && arr[1][i] == '1')
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BitwiseTwo(new string[] { "100", "000" }));
            Console.WriteLine(BitwiseTwo(new string[] { "10100", "11100" }));
            Console.WriteLine(BitwiseTwo(new string[] { "10111", "01101" }));
        }
    }
}
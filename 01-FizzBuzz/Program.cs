namespace _01_FizzBuzz
{
    // Kullanıcı tarafından pozitif bir tam sayı alınır. 
    // Daha sonra 1'den başlanarak girilen pozitif tam sayıya kadar birer birer arttırılarak kontrol işlemleri yapılır.
    // Bu kontrol işlemleri sayı 3'e tam bölünüyorsa "Fizz"; sayı 5'e tam bölünüyorsa "Buzz"; sayı hem 3'e hem 5'e tam bölünüyorsa "FizzBuzz" yazdırılır.
    // Eğer hiçbir bölme kuralına uymuyorsa sayının kendisi yazdırılır. 

    // Örnek Girdi: Console.WriteLine(FizzBuzz(12));
    //       Çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz

    // Örnek Girdi: Console.WriteLine(FizzBuzz(16));
    //       Çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16

    // Örnek Girdi: Console.WriteLine(FizzBuzz(32));
    //       Çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32

    internal class Program
    {
        private static string FizzBuzz(int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz ";
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    result += "Fizz ";
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    result += "Buzz ";
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }
            result = result.TrimEnd();
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(12));
            Console.WriteLine(FizzBuzz(16));
            Console.WriteLine(FizzBuzz(32));
        }
    }
}
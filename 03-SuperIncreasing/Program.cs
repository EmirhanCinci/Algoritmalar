namespace _03_SuperIncreasing
{
    // Kullanıcı tarafından pozitif tam sayıları içeren bir integer dizisi alın.
    // Dizinin, dizideki her elemanın önceki tüm elemanların toplamından daha büyük olduğu bir süper artan dizi oluşturup oluşturmadığını belirlemesini sağlayın.

    // Örnek Girdi: Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 3, 4 }));
    //       Çıktı: false

    // Örnek Girdi: Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 5, 10 }));
    //       Çıktı: true

    // Örnek Girdi: Console.WriteLine(SuperIncreasing(new int[] { 1, 3, 6, 13, 54 }));
    //       Çıktı: true

    internal class Program
    {
        private static bool SuperIncreasing(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (sum >= arr[i])
                {
                    return false;
                }
                sum += arr[i];
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 5, 10 }));
            Console.WriteLine(SuperIncreasing(new int[] { 1, 3, 6, 13, 54 }));
        }
    }
}
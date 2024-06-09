using System.Text;

namespace ConsoleApp1
{
    internal class DesafioMindbody
    {
        static void QuickSort(long[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(long[] arr, int low, int high)
        {
            long pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(long[] arr, int i, int j)
        {
            long temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int FindSmallestPositiveInteger(int[] values)
        {
            if (values == null || values.Length == 0)
                return 1;

            HashSet<int> set = new HashSet<int>();
            int min = 1;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > 0)
                    set.Add(values[i]);

            }

            while (set.Contains(min))
            {
                min++;
            }
            return min;
        }

        public static string FormatNotificationMessage(string message, int maxLength)
        {
            if (message == null)
            {
                return "...";
            }

            if (message.Length == 0)
            {
                return message;
            }

            var words = message.Split(' ').ToList();
            var remainingLength = maxLength < 4 ? maxLength - 4 : maxLength;

            if (words.Count > 0 && words[0].Length > maxLength)
            {
                return "...";
            }

            var formattedMessage = new StringBuilder();

            foreach (var word in words)
            {
                if (formattedMessage.Length + word.Length + 1 > remainingLength)
                {
                    return formattedMessage.ToString() + " ...";
                }
                else
                {
                    formattedMessage.Append(" ").Append(word);
                }
            }

            return formattedMessage.ToString();
        }
        public static string notificationWithTheRightAmountOfCaracters(string message, int K)
        {
            if (message == null)
                return "...";

            if (message.Length == 0)
                return message;


            List<string> words = message?.Split(' ').ToList() ?? new List<string>();
            int reducedAmount = K < 4 ? K - 4 : K;

            if (words.Count > 0 && words[0].Length > K)
                return "...";

            string value = String.Empty;

            for (int i = 0; i < words.Count; i++)
            {
                if ((words[i].Length + value.Length) > reducedAmount)
                    return value + " ...";
                else
                    value = i == 0 ? words[i] : value + " " + words[i];
            }

            return value;
        }

        public static string notificationWithTheRightAmountOfCaractersOriginal(string message, int K)
        {
            if (message == null)
                return "...";

            if (message.Length == 0)
                return message;


            List<string> words = message?.Split(' ').ToList() ?? new List<string>();
            int reducedAmount = K < 4 ? K - 4 : K;

            if (words.Count > 0 && words[0].Length > K)
                return "...";

            string value = String.Empty;

            for (int i = 0; i < words.Count; i++)
            {
                if ((words[i].Length + value.Length + 1) > reducedAmount)
                    return value + " ...";
                else
                    value = i == 0 ? words[i] : value + " " + words[i];
            }

            return value;
        }

        //Testes
        ////Random random = new Random();
        ////long[] arr = new long[10];
        ////for (int i = 0; i < arr.Length; i++)
        ////{
        ////    arr[i] = random.Next(11);
        ////}
        ////Console.WriteLine("Before sorting: " + string.Join(", ", arr));
        ////QuickSort(arr, 0, arr.Length - 1);
        ////Console.WriteLine("After sorting: " + string.Join(", ", arr));


        ////        ('And now here is my secret', 15)
        ////('There is an animal with four legs', 15)
        ////('super dog', 4)
        ////('how are you', 20)
        ////('how are you', 12)

        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("And now here is my secret", 15));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("There is an animal with four legs", 15));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("super dog", 4));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("how are you", 20));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("how are you", 11));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("yes", 4));
        //Console.WriteLine(notificationWithTheRightAmountOfCaractersOriginal("yes", 3));

        //Console.WriteLine(FormatNotificationMessage("And now here is my secret", 15));
        //Console.WriteLine(FormatNotificationMessage("There is an animal with four legs", 15));
        //Console.WriteLine(FormatNotificationMessage("super dog", 4));
        //Console.WriteLine(FormatNotificationMessage("how are you", 20));
        //Console.WriteLine(FormatNotificationMessage("how are you", 11));
        //Console.WriteLine(FormatNotificationMessage("yes", 4));
        //Console.WriteLine(FormatNotificationMessage("yes", 3));
    }
}

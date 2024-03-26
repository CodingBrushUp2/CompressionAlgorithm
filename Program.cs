using System.Text;

namespace CompressionAlgorithm;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            CompressString();
        }
    }

    private static void CompressString()
    {
        Console.WriteLine("Enter a string to compress:");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input string is empty.");
            return;
        }
        var compressed = Compressor.Compress(input);
        Console.WriteLine($"Compressed String: {compressed}");
        Console.WriteLine("Do you want to compress another string? (Y/N)");
        var response = Console.ReadLine();
        if (response?.ToUpper() != "Y")
        {
            Environment.Exit(0);
        }
    }
    public static class Compressor
    {
        public static string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var result = new StringBuilder();
            char currentChar = input[0];
            int currentCharCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    currentCharCount++;
                }
                else
                {
                    result.Append(currentCharCount);
                    result.Append(currentChar);

                    currentChar = input[i];
                    currentCharCount = 1;
                }
            }

            result.Append(currentCharCount);
            result.Append(currentChar);

            return result.Length < input.Length ? result.ToString() : input;
        }
    }
}

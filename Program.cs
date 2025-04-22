using System.Text;

class Program
{
    static void Main()
    {
        // Q#1 - Check if number is between 1 and 10
        Console.Write("Enter a number between 1 and 10: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= 1 && number <= 10)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");

        // Q#2 - Compare two numbers to find maximum or equality
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
            Console.WriteLine($"Maximum is: {num1}");
        else if (num2 > num1)
            Console.WriteLine($"Maximum is: {num2}");
        else
            Console.WriteLine("Both numbers are equal");

        // Q#3 - Determine image orientation
        Console.Write("Enter image width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter image height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        if (width > height)
            Console.WriteLine("Image is Landscape");
        else if (height > width)
            Console.WriteLine("Image is Portrait");
        else
            Console.WriteLine("Image is Square");

        // Q#4 - Check speed against limit and assign demerit points
        Console.Write("Enter speed limit: ");
        int speedLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter car speed: ");
        int carSpeed = Convert.ToInt32(Console.ReadLine());
        if (carSpeed <= speedLimit)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            int demeritPoints = (carSpeed - speedLimit) / 5;
            Console.WriteLine($"Demerit Points: {demeritPoints}");
            if (demeritPoints > 12)
                Console.WriteLine("License Suspended");
        }

        // Q#1 - Display message based on number of people who liked the post
        var names = new List<string>();
        while (true)
        {
            Console.Write("Enter a name or press Enter to finish: ");
            string userinput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userinput))
                break;
            names.Add(userinput);
        }
        if (names.Count == 1)
            Console.WriteLine($"{names[0]} likes your post.");
        else if (names.Count == 2)
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        else if (names.Count > 2)
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");

        // Q#2 - Reverse the user’s name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        char[] characters = name.ToCharArray();
        char[] reversed = new char[characters.Length];
        Console.WriteLine(characters.Length);
        for (int i = 0; i < characters.Length; i++)
        {
            reversed[i] = characters[characters.Length - 1 - i];
        }
        string reversedName = new string(reversed);
        Console.WriteLine("Reversed name: " + reversedName);

        // Q#3 - Ask user to enter 5 unique numbers and sort them
        var uniqueNumbers = new List<int>();
        while (uniqueNumbers.Count < 5)
        {
            Console.Write("Enter a unique number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool alreadyExists = false;
            foreach (int n in uniqueNumbers)
            {
                if (n == number1)
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (alreadyExists)
            {
                Console.WriteLine("Number already entered. Try again.");
                continue;
            }
            uniqueNumbers.Add(number1);
        }
        for (int i = 0; i < uniqueNumbers.Count - 1; i++)
        {
            for (int j = i + 1; j < uniqueNumbers.Count; j++)
            {
                if (uniqueNumbers[i] > uniqueNumbers[j])
                {
                    int temp = uniqueNumbers[i];
                    uniqueNumbers[i] = uniqueNumbers[j];
                    uniqueNumbers[j] = temp;
                }
            }
        }
        Console.Write("Sorted list of  numbers are : ");
        foreach (var num in uniqueNumbers)
            Console.Write(num + " ");

        // Q#4 - Accept multiple numbers until user quits, display only unique entries
        var enteredNumbers = new List<int>();
        var uniqueEntered = new List<int>();
        while (true)
        {
            Console.Write("Enter a number or type 'Quit' to exit: ");
            string userinput = Console.ReadLine();
            if (userinput.ToLower() == "quit")
                break;
            int num = Convert.ToInt32(userinput);
            enteredNumbers.Add(num);
        }
        foreach (var num in enteredNumbers)
        {
            bool exists = false;
            foreach (var n in uniqueEntered)
            {
                if (n == num)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
                uniqueEntered.Add(num);
        }
        Console.Write("Unique numbers: ");
        foreach (var num in uniqueEntered)
            Console.Write(num + " ");

        // Q#5 - Get a list of numbers and return 3 smallest after validation
        while (true)
        {
            Console.Write("Enter a list of comma separated numbers: ");
            string inputwords = Console.ReadLine();
            string[] sepratewords = inputwords.Split(',');
            if (sepratewords.Length < 5)
            {
                Console.WriteLine("Invalid List Try again.");
                continue;
            }
            var list_of_numbers = new List<int>();
            foreach (string part in sepratewords)
            {
                int parsed = Convert.ToInt32(part.Trim());
                list_of_numbers.Add(parsed);
            }
            for (int i = 0; i < list_of_numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < list_of_numbers.Count; j++)
                {
                    if (list_of_numbers[i] > list_of_numbers[j])
                    {
                        int temp = list_of_numbers[i];
                        list_of_numbers[i] = list_of_numbers[j];
                        list_of_numbers[j] = temp;
                    }
                }
            }
            Console.Write("3 Smallest numbers: ");
            for (int i = 0; i < 3; i++)
                Console.Write(list_of_numbers[i] + " ");
            break;
        }

        // Q#5 - Count vowels in a word
        Console.Write("Enter a word: ");
        string sentence = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }
        Console.WriteLine(count);

        // Q#2 - Check if input contains duplicate numbers
        Console.Write("Enter numbers separated by hyphen: ");
        string input_numbers = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input_numbers))
            return;
        string[] Parts = input_numbers.Split('-');
        for (int i = 0; i < Parts.Length; i++)
        {
            for (int j = i + 1; j < Parts.Length; j++)
            {
                if (Parts[i] == Parts[j])
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }
        }
        Console.WriteLine("No Duplicates");

        // Q#4 - Convert words into PascalCase
        Console.Write("Enter words: ");
        string inputWords = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputWords))
        {
            Console.WriteLine("Empty input");
            return;
        }
        string[] words = inputWords.ToLower().Split(' ');
        StringBuilder result = new StringBuilder();
        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                string capitalized = char.ToUpper(word[0]) + word.Substring(1);
                result.Append(capitalized);
            }
        }
        Console.WriteLine(result.ToString());

        // Q#1 - Check if numbers are consecutive
        Console.Write("Enter numbers separated by hyphen: ");
        string input = Console.ReadLine();
        string[] parts = input.Split('-');
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = Convert.ToInt32(parts[i]);
        }
        bool isAscending = true;
        bool isDescending = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
                isAscending = false;
            if (numbers[i] != numbers[i - 1] - 1)
                isDescending = false;
        }
        if (isAscending || isDescending)
            Console.WriteLine("Consecutive");
        else
            Console.WriteLine("Not Consecutive");

        // Q#3 - Validate 24-hour time format
        Console.Write("Enter time in 24hour format (HH:mm): ");
        string inputTime = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputTime))
        {
            Console.WriteLine("Invalid Time");
            return;
        }
        string[] sepratedParts = input.Split(':');
        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid Time");
            return;
        }
        try
        {
            int hour = int.Parse(sepratedParts[0]);
            int minute = int.Parse(sepratedParts[1]);
            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
        catch
        {
            Console.WriteLine("Invalid Time");
        }

        // Q#1 & Q#2 - Read a file and find word count and longest word
        string path = @"G:\Zubair Data\InternShip Data\sample.txt";
        FileInfo file = new FileInfo(path);
        if (!file.Exists)
        {
            Console.WriteLine("File does not exist");
            return;
        }
        string content = File.ReadAllText(path);
        int wordcount = 0;
        string longestword = "";
        char[] separators = { ' ', '\n', '\r', '\t', '.', ',', ';', '-', '_', '!', '?', '(', ')', '[', ']', '"' };
        string[] rawwords = content.Split(separators);
        foreach (string word in rawwords)
        {
            if (word != "") wordcount++;
            if (word.Length > longestword.Length) longestword = word;
        }
        Console.WriteLine("Total words are:" + wordcount);
        Console.WriteLine("Longest word Count is:" + longestword);
    }
}
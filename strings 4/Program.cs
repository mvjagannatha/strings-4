using System;

class StringOperations
{
    static void Main()
    {
        // Accept a string from the user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // 1) Print the string in reverse order
        string reversedString = new string(inputString.Reverse().ToArray());
        Console.WriteLine("Reversed String: " + reversedString);

        // 2) Extract part of the string from the second position till the end
        string extractedString = inputString.Substring(1);
        Console.WriteLine("Substring from second position: " + extractedString);

        // 3) Replace a given character by $
        Console.Write("Enter a character to replace: ");
        char charToReplace = Console.ReadKey().KeyChar;
        string replacedString = inputString.Replace(charToReplace, '$');
        Console.WriteLine("\nString with replaced character: " + replacedString);

        // 4) Copy the string to another variable, modify the data in the second variable, and print both strings
        string copiedString = inputString;
        Console.Write("\nEnter a new string to modify the copied string: ");
        string modifiedString = Console.ReadLine();

        Console.WriteLine("Original String: " + inputString);
        Console.WriteLine("Copied String: " + copiedString + "\nModified Copied String: " + modifiedString);

        Console.ReadKey();
    }
}

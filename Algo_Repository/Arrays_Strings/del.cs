using System;

class Program
{
    // Decrypts a ROT(N) encrypted string by shifting N positions in the opposite direction
    static string DecryptRot(string encryptedText, int shift)
    {
        // Initialize an empty string to store the decrypted text
        string decryptedText = "";

        // Loop through each character in the encrypted text
        foreach (char c in encryptedText)
        {
            // Check if the character is an uppercase letter
            if (char.IsUpper(c))
            {
                // Shift the character back by N positions
                char decryptedChar = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                decryptedText += decryptedChar;
            }
            // Check if the character is a lowercase letter
            else if (char.IsLower(c))
            {
                // Shift the character back by N positions
                char decryptedChar = (char)(((c - 'a' - shift + 26) % 26) + 'a');
                decryptedText += decryptedChar;
            }
            // If the character is not a letter, keep it as is
            else
            {
                decryptedText += c;
            }
        }

        return decryptedText;
    }

    static void Main()
    {
        // Example usage
        string encryptedText = "havdhr uryyb jbeyq";
        int shift = 13;
        string decryptedText = DecryptRot(encryptedText, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusNCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlusNCipher();
        }

        private static void PlusNCipher()
        {
            Console.WriteLine("Introduceti textul latin pe care doriti sa il incriptati:");
            string plainText=Console.ReadLine();
            Console.WriteLine("Introduceti cheia de criptare n:");
            int shift=int.Parse(Console.ReadLine());
            string cipherText=PlusN_Encryipt(plainText, shift);
            Console.WriteLine($"Encrypted:{cipherText}.");
            string decryptedText=PlusN_Decrypt(cipherText, shift);
            Console.WriteLine($"Decrypted:{decryptedText}.");
            Console.ReadKey();
        }

        private static string PlusN_Decrypt(string cipherText, int shift)
        {
            string decryptedText = "";
            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC - shift - 'a' + 26) % 26) + 'a');
                    decryptedText += shifted;
                }
                else
                {
                    decryptedText += c;
                }
            }
            return decryptedText;
        }

        private static string PlusN_Encryipt(string plainText, int shift)
        {
            string cipherText = "";
            foreach(char c in plainText)
            {
                if(char.IsLetter(c))
                {
                    char lowerC=char.ToLower(c);
                    char shifted= (char)(((lowerC + shift - 'a') % 26) + 'a');
                    cipherText += shifted;
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }
    }
}

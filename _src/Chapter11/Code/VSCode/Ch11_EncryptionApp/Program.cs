﻿using System;
using Packt.CS7;
using static System.Console;

namespace Ch11_EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a message that you want to encrypt: ");
            string message = ReadLine();
            Write("Enter a password: ");
            string password = ReadLine();
            string cryptoText = Protector.Encrypt(message, password);
            WriteLine($"Encrypted text: {cryptoText}");
            Write("Enter the password: ");
            string password2 = ReadLine();
            try
            {
                string clearText = Protector.Decrypt(cryptoText, password2);
                WriteLine($"Decrypted text: {clearText}");
            }
            catch
            {
                WriteLine(
                  "Enable to decrypt because you entered the wrong password!");
            }
        }
    }
}

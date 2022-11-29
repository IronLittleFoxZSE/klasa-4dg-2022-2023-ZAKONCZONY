using System;

namespace CaesarCode
{
    public class CaesarCodeClass
    {
        public string Encrypt(string textToEncrypt, int shift)
        {
            string enctypyText = "";
            char minChar=' ';
            char maxChar=' ';
            bool encryptCharFlag = false;
            int loopShift = 0;
            foreach (char character in textToEncrypt)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    minChar = 'A';
                    maxChar = 'Z';
                    encryptCharFlag = true;
                    loopShift = shift % (maxChar - minChar);
                }
                   
                if (character >= 'a' && character <= 'z')
                {
                    minChar = 'a';
                    maxChar = 'z';
                    encryptCharFlag = true;
                    loopShift = shift % (maxChar - minChar);
                }
                if (character >= '0' && character <= '9')
                {
                    minChar = '0';
                    maxChar = '9';
                    encryptCharFlag = true;
                    loopShift = shift % (maxChar - minChar);
                }

                char encryptChar = character;
                if (encryptCharFlag)
                {
                    encryptChar = (char)(character + loopShift);
                    if (encryptChar > maxChar)
                        encryptChar = (char)(encryptChar - (maxChar - minChar + 1));
                    if (encryptChar < minChar)
                        encryptChar = (char)(encryptChar + (maxChar - minChar + 1));

                    encryptCharFlag = false;
                    loopShift = shift;
                }
                enctypyText += encryptChar;
            }
            return enctypyText;
        }

        public string Decrypt(string textToDecrypt, int shift)
        {
            return Encrypt(textToDecrypt, shift);
        }

    }
}

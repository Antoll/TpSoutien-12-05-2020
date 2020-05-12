using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cryptanalysis
{
    public class Caesar
    {
        private int key;

        public Caesar(int key)
        {
            this.key = key;
        }

        public string Encrypt(string msg)
        {
            int l = msg.Length;
            int i = 0;
            while (i <= l)
            {
                if (Tools.LetterIndex(msg[i]) != -1)
                {
                    Tools.RotChar(msg[i], key);
                }

                i++;
            }

            return msg;
        }

        public string Decrypt(string cypherText)
        {
            int l = cypherText.Length;
            int i = 0;
            while (i <= l)
            {
                if (Tools.LetterIndex(cypherText[i]) != -1)
                {
                    Tools.RotChar(cypherText[i], -key);
                }

                i++;
            }

            return cypherText;
        }

        public static int GuessKey(string cypherText)
        {
            int[] guess = Tools.Histogram(cypherText);
            int max = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] > guess[max]) max = i;
            }

            int key = max - 4;
            return key;
        }
        
    }
}
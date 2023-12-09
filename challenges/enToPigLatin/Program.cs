using System;
using System.Text;

namespace enToPigLatin; 

public static class Program {
    private static void TranslateWord(string word) {
        bool isVowel = "aeiouAEIOU".IndexOf(word[0]) >= 0;

        if(isVowel) {
            Console.WriteLine("Vowel");
            Console.WriteLine(word + "yay");
        } else {
            Console.WriteLine("Consonant");

            StringBuilder builder = new StringBuilder(word);
            builder.Remove(0, 1);
            builder.Append(word[0]);
            word.ToString();
            Console.WriteLine(word + "ay");//incomplete it is not just the first schar but until yoo reach an vowel
        }
    }

    public static void TranslateSentence(string sentence) {
        //incomplete obviously
    }

    static void Main(string[] args) {
        TranslateWord("flag");
        TranslateWord("Apple");
    }
}   

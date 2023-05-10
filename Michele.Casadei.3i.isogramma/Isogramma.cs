using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
     var Alfabeto = new int [26];
        foreach(var Lettera in word.ToLower())
        {
            if (Char.IsLetter(Lettera))
            {
                Alfabeto [Lettera - 'a']++;
                if (Alfabeto[Lettera - 'a'] > 1)
                    return false;
            }
        }
        
        return true;

    }
}

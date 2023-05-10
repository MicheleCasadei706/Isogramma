# Isogramma
## Scopo del programma
Lo scopo dell'esercizo è determinare se una parola o una frase è un isogramma.

### Cos'è un isogramma?

Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute.
Sono ammessi spazi e segni di punteggiatura ripetuti.

Esempi di isogrammi:

- lumberjacks
- background
- downstream
- six-year-old

Per maggiori informazioni sugli isogrammi, consulta [Wikipedia sugli Isogrammi](https://it.wikipedia.org/wiki/Isogramma)

Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.

Per esempio le cifre decimali possono essere mappate secondo questo schema:

P	A	T	H	F	I	N	D	E	R

1	2	3	4	5	6	7	8	9	0

Ammettiamo che il prezzo indicato fosse 1200 € ma nel cartellino ci fossero anche le lettere FRR, il venditore saprebbe che il prezzo originale era 500 € in modo da non scendere sotto quella soglia.

Un isogramma di 12 lettere si può usare per mappare i mesi dell'anno.

### Codice

```C#
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
```

Il programma inizia con un vettore di interi chiamato Alfabeto di lunghezza 26, che viene utilizzato per contare il numero di occorrenze di ciascuna lettera dell'alfabeto in una data parola.
Questo vettore è inizializzato con tutti i suoi elementi impostati su 0.
La funzione Verifica riceve una stringa come parametro e cicla attraverso ogni carattere della stringa convertendolo in minuscolo per garantire l'uniformità nella conta.
Per ogni carattere, viene controllato se è una lettera utilizzando il metodo Char.IsLetter.
In tal caso, il programma incrementa il valore corrispondente nell'array Alfabeto.
Se l'array Alfabeto ha un valore maggiore di 1 per qualsiasi lettera, la funzione restituisce FALSE, altrimenti, restituisce TRUE.
Dunque, se una lettera compare più di una volta nella stringa, la funzione restituisce false in quanto la stringa non è un isogramma.


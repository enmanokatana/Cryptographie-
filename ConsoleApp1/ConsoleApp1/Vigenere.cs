using System.IO.Compression;

namespace ConsoleApp1;

public class Vigenere
{
    // (x1,X2,...,xk) === (X1+N1,x2+n2,...,xk+nk)
    private List<int> message = new List<int>();
    private int TailleBloc;

    public Vigenere(List<int> message, int k)
    {
        this.message = message;
        this.TailleBloc = k;
    }

    public List<int[]> Decaler(List<int> Nbres)
    {
        List<int[]> Blocs = new List<int[]>();

        // Vérifiez si la taille de la liste est un multiple de la taille du bloc
        if (Nbres.Count % TailleBloc != 0)
        {
            Console.WriteLine("La taille de la liste n'est pas un multiple de la taille du bloc.");
            return Blocs; // Retournez une liste vide ou gérez cette situation selon vos besoins.
        }

        int t = 0;

        // Parcourez la liste par blocs
        for (int k = 0; k < Nbres.Count / TailleBloc; k++)
        {
            int[] Nomberes = new int[TailleBloc];

            // Parcourez chaque élément dans le bloc
            for (int i = 0, j = t; i < TailleBloc; i++)
            {
                Nomberes[i] = Nbres[j] + i; // Décalage des nombres
                j++;
            }

            t += TailleBloc;

            // Ajoutez le bloc décalé à la liste
            Blocs.Add(Nomberes);
        }

        // Affichez tous les blocs décalés
        for (int i = 0; i < Blocs.Count; i++)
        {
            Console.WriteLine($"Bloc {i + 1}: {string.Join(", ", Blocs[i])}");
        }

        return Blocs;
    }
}
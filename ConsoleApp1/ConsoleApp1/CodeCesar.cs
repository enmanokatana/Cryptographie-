using System.Text;

namespace ConsoleApp1;
using System.Collections.Generic;
public class CodeCesar
{
    private const int k =3 ;
    private Dictionary<char, int> lettreEnNbre = new Dictionary<char, int>();
    Dictionary<int, char> numberToLetter = new Dictionary<int, char>();

    
    public CodeCesar()
    {
        for (char lettre = 'A'; lettre <= 'Z'; lettre++)
        {
            lettreEnNbre.Add(lettre,lettre-'A');
        }
        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            numberToLetter.Add(letter - 'A', letter);
        }
 
    }

    public List<int> Nombrement(String message)
    {
        List<int> NvMsg = new List<int>();
        foreach (char c in message)
        {
            NvMsg.Add(lettreEnNbre[c]);
            Console.Write(lettreEnNbre[c]);
        }
        Console.WriteLine("");

        return NvMsg;
    }

    public List<int> Decalage(List<int> message,int k)
    {
        for (int i = 0; i < message.Count; i++)
        {
            message[i] += k;
            message[i] %= 26;

            Console.Write(message[i]);
        }
        Console.WriteLine("");

        return message;
    }

    public string Dechiffrement(List<int> message, int k)
    {
        StringBuilder Nvmessage = new StringBuilder();

        for (int i = 0; i < message.Count; i++)
        {
            Console.Write(message[i]);
            message[i] -= k;
            message[i] %= 26;
        }

        foreach (int i in message)
        {
            Nvmessage.Append(numberToLetter[i]);
        }

        return Nvmessage.ToString();
    }

    
}
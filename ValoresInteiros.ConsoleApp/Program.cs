using System.Runtime.Serialization;
using System.Linq;
using System.Runtime.InteropServices;

internal class Program
{
    
    private static void Main(string[] args)
    {
        int[] seq = new int[10];
        InformarValores(seq);
        Console.WriteLine($"O valor máximo é: {EncontrarValorMax(seq)}");
        Console.WriteLine($"O valor mínimo é: {EncontrarValorMin(seq)}");
        Console.WriteLine($"O valor médio é: {EncontrarValorMédio(seq)}");
        Console.Write("Os três maiores valores são: "); MostrarValores(EncontrarTresMaioresValores(seq));
        Console.Write("Os números negativos são: "); MostrarValores(EncontrarValoresNegativos(seq));
        Console.Write("Os valores da sequência são: "); MostrarValores(seq);
        Console.WriteLine("Informe um valor da sequência para remover: ");
        int valorRemovido = int.Parse(Console.ReadLine());
        MostrarValores(RemoverItem(seq, valorRemovido));
    }
    static void InformarValores(int[] seq)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Informe o {i+1} valor: ");
            seq[i] = int.Parse(Console.ReadLine());
        }
    }
    static int EncontrarValorMax(int[] seq)
    {
        return seq.Max();
    }
    static int EncontrarValorMin(int[] seq)
    {
        return seq.Min();
    }
    static int EncontrarValorMédio(int[] seq)
    {
       int soma = 0;
        
        for(int i = 0; i < 10 ; i++)
        {
            soma += seq[i];
        }
        return soma/10;

    }
    static int[] EncontrarTresMaioresValores(int[] seq)
    {
        return seq.OrderByDescending(x => x).Take(3).ToArray();
    }
    static int[] EncontrarValoresNegativos(int[] seq)
    {
        return seq.Where(x => x < 0).ToArray();
    }
    static void MostrarValores(int[] seq) {
        for(int i = 0; i < seq.Length; i++)
        {
            Console.Write($"{seq[i]} ");
        }
        Console.WriteLine();
    }
    static int[] RemoverItem(int[] seq, int valorRemovido)
    {
        for(int i = 0; i < seq.Length; i++)
        {
            if(valorRemovido == seq[i])
            {
                seq[i] = 0;
            }
        }
        return seq;
    }
}   

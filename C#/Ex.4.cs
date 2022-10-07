using System;

class Program 
{
  static double fazerMedia(double n1, double n2, double n3, double n4){
    double media = (n1 + n2 + n3 + n4) / 4;
    return media;
  }

  static void operacao(double media){
    if (media >= 7){
      Console.WriteLine("Você foi aprovado");
    } else {
      Console.WriteLine("Você foi reprovado");
    }
  }
  public static void Main (string[] args) 
  {
    double n1, n2, n3, n4, media;

    Console.WriteLine("Insira sua 1° nota: ");
    n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira sua 2° nota: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira sua 3° nota: ");
    n3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira sua 4° nota: ");
    n4 = Convert.ToInt32(Console.ReadLine());

    media = fazerMedia(n1, n2, n3, n4);
    operacao(media);
  }
}
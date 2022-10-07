using System;

class Program {
  static void somaNumeros(int n1, int n2){
      Console.WriteLine($"O resultado da soma é: {n1 + n2}");
  }
  
  public static void Main (string[] args) {
    int n1, n2;
    Console.WriteLine("Insira o 1° número: ");
    n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o 2° número: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    somaNumeros(n1, n2);
  }
}
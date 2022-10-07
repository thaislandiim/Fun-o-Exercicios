using System;

class Program {
  static double somaNumeros(double n1, double n2, double n3){
      return n1 + n2 + n3;
    }
  public static void Main (string[] args) {
    double n1, n2, n3;
    
    Console.WriteLine("Insira o 1° número: ");
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o 2° número: ");
    n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o 3° número: ");
    n3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"O resultado da soma é: {somaNumeros(n1, n2, n3)}");
  }
}
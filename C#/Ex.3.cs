using System;

class Program {
    static int soma2(int valor){
      valor = valor + 2;
      return valor;
    }

    static int multi2(int valor1){
      valor1 = valor1 * 2;
      return valor1;
    }
  
  public static void Main (string[] args) {
    int[] vetor = new int[10];
    int[] vetor1 = new int[10];

    for(int v = 0; v < 10; v++){
      Console.WriteLine("Insira um número: ");
      vetor[v] = Convert.ToInt32(Console.ReadLine());

      if(vetor[v] % 2 == 0){
        vetor[v] = soma2(vetor[v]);
        vetor1[v] = 0;
      } else {
        vetor[v] = multi2(vetor[v]);
        vetor1[v] = 1;
      }
    }
    Console.WriteLine("Números pares: ");
    for(int v = 0; v < 10; v++){
      if(vetor1[v] == 0){
        Console.WriteLine(vetor[v]);
      }
    }
    Console.WriteLine("Números impares: ");
    for(int v = 0; v < 10; v++){
      if(vetor1[v] == 1){
        Console.WriteLine(vetor[v]);
      }
    }
  }
}
using System;
using conhecendo_csharp.Exemplos;

namespace conhecendo_csharp {
  class Program {
    static void Main(string[] args) {
      var s = new Pilha(); // ou var s = new Exemplos.Pilha(); assim não teria a necessidade da cláusula (using) acima

      s.Empilha(1);
      s.Empilha(10);
      s.Empilha(100);
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha()); // estourando a seção do Desempilha(); pilha vazia
    }
  }
}

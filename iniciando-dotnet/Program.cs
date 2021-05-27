using System; // pacote nativo do dotnet que nos fornece as ferramentas utilizáveis durante o desenvolvimento do projeto (ex.: Console.WriteLine("");)

namespace iniciando_dotnet {
  class Program {
    static void Main(string[] args) {
      int numVezes = 5;

      for (int i = 0; i < numVezes; i++) {
        Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
      }
    }
  }
}

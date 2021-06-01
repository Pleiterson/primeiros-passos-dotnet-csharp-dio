namespace classes_objetos.Metodos {
  public class Out {
    static void Dividir(int x, int y, out int resultado, out int resto) {
      resultado = x / y; // retorna o resultado da divisão de x por y
      resto = x % y; // retorna o resto da divisão x por y, mode
    }
    
    public static void Dividir() {
      Dividir(10, 3, out int resultado, out int resto); // out vai ser o valores das variáveis após a execução do método Dividir()
      System.Console.WriteLine("{0} {1}", resultado, resto); // Escreve "3 1"
    }
  }
}
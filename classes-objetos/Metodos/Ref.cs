namespace classes_objetos.Metodos {
  public interface Ref {
    static void Inverter(ref int x, ref int y) { // inverte os valores das variáveis passadas por parâmetro
      int temp = x;
      x = y;
      y = temp;
    }

    public static void Inverter() {
      int i = 1, j = 2;
      Inverter(ref i, ref j);

      // se não tivesse o ref ao chamar o método Inverter() acima, e no próprio método nada aconteceria e ia ser impresso na tela "1 2"
      System.Console.WriteLine($"{i} {j}"); // Escreve "2 1"
    }
  }
}
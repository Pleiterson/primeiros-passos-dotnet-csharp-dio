namespace classes_objetos.Herança {
  public class Ponto {
    public int x, y; // variáveis inteiras públicas
    private int distancia; // variável privada, só é acessada dentro da classe Ponto
    
    public Ponto(int x, int y) {
      this.x = x; // this refere-se ao x declarado de forma pública
      this.y = y; // this refere-se ao y declarado de forma pública
    }

    protected void CalcularDistancia() { // quem herdar a classe Ponto terá acesso a este método devido ao protected
      //Faz alguma coisa...
      CalcularDistancia2(); // chamando o método CalcularDistancia2();
    }

    private void CalcularDistancia2() { // só pode ser utilizado dentro da classe Ponto, classes filhas não tem acesso
      //Faz alguma coisa...
    }

    public virtual void CalcularDistancia3() { // método permite que uma classe filha sobrescreva a ação dele devido ao virtual
      //Faz alguma coisa...
    }
  }
}
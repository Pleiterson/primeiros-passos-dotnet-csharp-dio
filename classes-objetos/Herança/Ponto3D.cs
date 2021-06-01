namespace classes_objetos.Herança {
  public class Ponto3D : Ponto { // a classe Ponto3D herda os métodos da classe Ponto, só pode herdar apenas uma classe
    public int z; // variável pública
    public Ponto3D(int x, int y, int z) : base(x, y) { // passando os valores de x e y da classe Ponto
      this.z = z;
      CalcularDistancia(); // chamado o método que está na classe Ponto
    }

    public static void Calcular() { // por ser um método estático ele pertence apenas a classe e não a instância
      //Faz alguma coisa...
    }
    public override void CalcularDistancia3() { // sobrescreve o método CalcularDistancia3() da classe Ponto devido ao virtual/override
      //Faz outra coisa ...
      base.CalcularDistancia3();
    }
  }
}
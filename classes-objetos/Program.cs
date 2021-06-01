using System;
using classes_objetos.Herança;

namespace classes_objetos {
  class Program {
    static void Main(string[] args) {
      Ponto p1 = new Ponto(10,20); // p1 só vai ter acesso aos dados públicos da classe Ponto: x, y e CalcularDistancia3()
      Ponto p2 = new Ponto3D(10,20,30); // p2 vai ter acesso aos dados públicos da classe Ponto3D: x, y e no caso de CalcularDistancia3() vai sobrescrever o mesmo método da classe Ponto
      Ponto3D p3 = new Ponto3D(10,20,30); // p3 vai ter acesso aos dados públicos da classe Ponto3D: x, y, z e no caso de CalcularDistancia3() vai sobrescrever o mesmo método da classe Ponto

      // nenhuma das instâncias p1, p2 e p3 consegue acessar a métodos estáticos de suas classes, apenas acessando diretamente conforme abaixo
      Ponto3D.Calcular(); // acessando um método estático da classe Ponto3D
    }
  }
}

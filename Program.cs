using System;
namespace Desafio01_SPMenorPreco;
class Program
{
  static void Main(String[] args)
  {
    Produto leiteCondensado = new Produto();
    leiteCondensado.nome = "Selma";
    leiteCondensado.valorCompra = 3.42;
    leiteCondensado.valorUnitario = 5.60;
    leiteCondensado.fabricante = "Sergio Luiz Marangone";
    leiteCondensado.codigoDeBarras = 9873213253425;
    leiteCondensado.estoque = 160;
  }
}
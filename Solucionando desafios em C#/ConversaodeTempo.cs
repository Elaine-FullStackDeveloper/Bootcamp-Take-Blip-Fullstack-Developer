/*

Desafio: Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada: O arquivo de entrada contém um valor inteiro N.
Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
 
Exemplo de Entrada |Exemplo de Saída
---------------------------------------
556                |     0:9:16
---------------------------------------
1                  |     0:0:1
*/

using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var N = int.Parse(Console.ReadLine());
    var horas = N/3600;
    var minutos = (N%3600)/60; 
    var segundos = (N%60); 

    Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
  }
}

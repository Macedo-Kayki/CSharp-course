using System;

class MainClass {

  public static string LongestWord(string sen) {

    string[] palavras = sen.Split(' ');

    string MaiorPalavra = "";

    foreach (string PalavraAtual in palavras){
      if (PalavraAtual.Length > MaiorPalavra.Length){
        MaiorPalavra = PalavraAtual;
      }
    }
    return MaiorPalavra;

  }

  static void Main() {

    Console.WriteLine(LongestWord(Console.ReadLine()));
    
  } 

}

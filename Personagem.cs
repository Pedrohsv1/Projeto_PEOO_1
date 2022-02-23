using System;
using System.Collections;
using System.Collections.Generic;

class Personagem : IComparable
{
  
  public string Nome { get ; set; }
  public int Level { get ; set; }
  public string Type { get ; set; }
  public Artefato Flor { get ; set; }
  public Artefato Pena { get ; set; }
  public Artefato Relogio { get ; set; }
  public Artefato Calice { get ; set; }
  public Artefato Tiara { get ; set; }

  public override string ToString()
  {
    return $"{Nome} - {Type}\nLevel: {Level}
    \nArtefato Flor:
    {Flor}\nArtefato Pena:
    {Pena}\nArtefato Relogio:
    {Relogio}\nArtefato Tiara:
    {Tiara}\nArtefato Cálice:
    {Calice}";
  }
  public void Cadastrar()
  {
    Console.WriteLine("Informaçoes do Seu Personagem");
    Console.Write("Nome: ");
    this.Nome = Console.ReadLine();
    
  }
  public int CompareTo(object obj)
  {
    Personagem x = this;
    Personagem y = (Personagem) obj;

    return x.Nome.CompareTo(y.Nome);
  }
}
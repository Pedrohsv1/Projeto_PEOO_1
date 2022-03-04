using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

  public int Mora { get ; set; }
  public int Xp { get ; set; }
  public int Lasca { get ; set; }
  public int Fragmento { get ; set; }
  public int Pedaco { get ; set; }
  public int Gema { get ; set; }
  public int Boss { get ; set; }

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
    Console.Write("Type: ");
    this.Type = Console.ReadLine();
    
  }
  public int CompareTo(object obj)
  {
    Personagem x = this;
    Personagem y = (Personagem) obj;

    return x.Nome.CompareTo(y.Nome);
  }
  public int MoraXP()
  {
    int x = this.Level/10;

    if ( x == 0 )
  {
    this.Mora = 2092530;
    this.Xp = 419;
    this.Lasca = 1;
    this.Fragmento = 9;
    this.Pedaco = 9;
    this.Gema = 6;
    this.Boss = 46;

  }
  if ( x == 1 )
    {
      this.Mora = 2087525;
      this.Xp = 417;
      this.Lasca = 1;
      this.Fragmento = 9;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 46;
  
    }
  if ( x == 2 )
    {
      this.Mora = 2068495;
      this.Xp = 413;
      this.Lasca = 1;
      this.Fragmento = 9;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 46;
  
    }
  if ( x == 3 )
    {
      this.Mora = 2005910;
      this.Xp = 402;
      this.Lasca = 0;    
      this.Fragmento = 9;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 46;
  
    }
  if ( x == 4 )
    {
      this.Mora = 1932830;
      this.Xp = 384;
      this.Lasca = 0;
      this.Fragmento = 9;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 44;
  
    }
  if ( x == 5 )
    {
      this.Mora = 1777010;
      this.Xp = 355;
      this.Lasca = 0;
      this.Fragmento = 6;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 44;
  
    }
  if ( x == 6 )
    {
      this.Mora = 1546185;
      this.Xp = 312;
      this.Lasca = 0;
      this.Fragmento = 0;
      this.Pedaco = 9;
      this.Gema = 6;
      this.Boss = 40;
  
    }
  if ( x == 7 )
    {
      this.Mora = 1227000;
      this.Xp = 252;
      this.Lasca = 0;
      this.Fragmento = 0;
      this.Pedaco = 6;
      this.Gema = 6;
      this.Boss = 32;
  
    }
  if ( x == 8 )
    {
      this.Mora = 804625;
      this.Xp = 172;
      this.Lasca = 0;
      this.Fragmento = 0;
      this.Pedaco = 0;
      this.Gema = 6;
      this.Boss = 20;
  
    }
      if ( x == 9 )
    {
      this.Mora = 0;
      this.Xp = 0;
      this.Lasca = 0;
      this.Fragmento = 0;
      this.Pedaco = 0;
      this.Gema = 0;
      this.Boss = 46;
  
    }

    return x;
  }
}

class NomeComparer : IComparer<Personagem>
{
  public int Compare(Personagem x, Personagem y)
  {
    return x.Nome.CompareTo(y.Nome);
  }
}
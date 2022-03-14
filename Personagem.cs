using System;
using System.Collections;
using System.Collections.Generic;


class Personagem : IComparable<Personagem>
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
    {Calice}\n===============================";
  }
  public void Cadastrar()
  {
    Console.WriteLine("Informaçoes do Seu Personagem");
    Console.Write("Nome: ");
    this.Nome = Console.ReadLine();
    Console.Write("Level: ");
    this.Level = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite para o tipo:\n[1] Hydro\n[2] Pyro\n[3] Cryo\n[4] Electro\n[5] Geo\n[6] Anemo");
    Console.Write("Digite: ");
    int TypeC = int.Parse(Console.ReadLine());
    if (TypeC == 1) Type = "Hydro";
    if (TypeC == 2) Type = "Pyro";
    if (TypeC == 3) Type = "Cryo";
    if (TypeC == 4) Type = "Electro";
    if (TypeC == 5) Type = "Geo";
    if (TypeC == 6) Type = "Anemo";
  }
  public int CompareTo(Personagem Obj)
  {
    return Nome.CompareTo(Obj.Nome);
  }
  public int MoraXp()
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
  Console.WriteLine();  
  Console.WriteLine($"{this.Nome} | {this.Type}");
  Console.WriteLine($"Mora: {this.Mora}\nLivro 20k x Xp: {this.Xp}\nLasca: {this.Lasca}\nFragmento: {this.Fragmento}\nPedaço: {this.Pedaco}\nGema: {this.Gema}\nBoss: {this.Boss}");
  Console.WriteLine();  

    return x;
  }
  public void PersonagemArtefato(string T, Colecao<Artefato> Aux, int i)
  {
    int contador = 0;
        foreach (Artefato a in Aux.Listar())
          {
            if ( a.Type == T) 
            {
              Console.WriteLine($"[{contador+1}] {a}");
              contador++;
            }
          }
        if (contador == 0)
        {
          Console.WriteLine($"Cadastre um/a {T} no MENU.");
        }
        else
        {
          contador = 0;
          Console.WriteLine("Digite o valor informado conjunto ao artefato:");
          int artefato_escolhido = int.Parse(Console.ReadLine());
          foreach (Artefato a in Aux.Listar())
          {
            if ( a.Type == T)
            {
              if ( artefato_escolhido - 1 == contador) 
              {
                Console.WriteLine(a);
                if (i == 0) this.Flor = a;
                if (i == 1) this.Pena = a;
                if (i == 2) this.Relogio = a;
                if (i == 3) this.Calice = a;
                if (i == 4) this.Tiara = a;
              }
              contador++;
            }
            
          }
        }
  }
}
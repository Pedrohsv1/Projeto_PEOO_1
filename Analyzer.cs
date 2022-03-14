using System;
using System.Collections;
using System.Collections.Generic;


class main
{
  static void Main()
  {
    int run = -1;
    Console.WriteLine("===============================");
    Console.WriteLine("       Anlayzer Genshin");
    Console.WriteLine("===============================");
    Console.WriteLine();
    
    Artefato Arte1 = new Artefato{Name = "Trupe Itinerante", Type = "Flor", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};


    Artefato Arte2 = new Artefato{Name = "Trupe Itinerante", Type = "Relogio", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG", ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte3 = new Artefato{Name = "Trupe Itinerante", Type = "Tiara", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte4 = new Artefato{Name = "Trupe Itinerante", Type = "Pena", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte5 = new Artefato{Name = "Trupe Itinerante", Type = "Calice", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};


    Personagem Childe = new Personagem{Nome = "Tartaglia", Level = 90, Type = "Hydro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};

    Personagem Hu = new Personagem{Nome = "Hu Tao", Level = 90, Type = "Pyro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};
    
    Personagem Ayaka = new Personagem{Nome = "Ayaka", Level = 90, Type = "Cryo", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};
    
    Personagem Mona = new Personagem{Nome = "Mona", Level = 11, Type = "Hydro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};

    Colecao<Personagem> Lista_Personagens = new Colecao<Personagem>();

    Lista_Personagens.Inserir(Childe);
    Lista_Personagens.Inserir(Hu);
    Lista_Personagens.Inserir(Ayaka);
    Lista_Personagens.Inserir(Mona);

    Colecao<Artefato> Artefatos = new Colecao<Artefato>();

    Artefatos.Inserir(Arte1);
    Artefatos.Inserir(Arte2);
    Artefatos.Inserir(Arte3);
    Artefatos.Inserir(Arte4);
    Artefatos.Inserir(Arte5);

    while (run != 00)
    {
      run = Menu();
      
      if (run == 1)
      {
        Personagem aux = new Personagem();
        aux.Cadastrar();
        aux.PersonagemArtefato("Flor", Artefatos, 0);
        aux.PersonagemArtefato("Pena", Artefatos, 1);
        aux.PersonagemArtefato("Relogio", Artefatos, 2);
        aux.PersonagemArtefato("Calice", Artefatos, 3);
        aux.PersonagemArtefato("Tiara", Artefatos, 4);
        
        Lista_Personagens.Inserir(aux);
      }
      if (run == 2)
      {  
        Artefato aux0 = new Artefato();
        aux0.CadastrarArtefato();
        Artefatos.Inserir(aux0);
      }
      if (run == 3)
      {
        MenuPrincipalPersonagem(Lista_Personagens, Artefatos);
      }
      if (run == 4)
      {
        MenuArtefatos(Artefatos);
      }
      
    }
  }
  static public int Menu()
  {
      Console.WriteLine("===============================");
      Console.WriteLine("              Menu");
      Console.WriteLine("===============================");
      Console.WriteLine();
      Console.WriteLine("[1] Cadastrar Personagem");
      Console.WriteLine("[2] Cadastrar Artefato");
      Console.WriteLine("[3] Listar Personagens");
      Console.WriteLine("[4] Listar Artefatos");
      Console.WriteLine("[00] Sair");
      Console.WriteLine();
      Console.WriteLine("Digite:");
      int M = int.Parse(Console.ReadLine());
      Console.WriteLine("===============================");
      Console.WriteLine();

      return M;
  }
  static public void MenuPrincipalPersonagem(Colecao<Personagem> Perso, Colecao<Artefato> a)
  {
        Console.WriteLine("===============================");
        Console.WriteLine("            Personagens");
        Console.WriteLine("===============================");
        Console.WriteLine();
        Personagem[] aux1 = new Personagem[Perso.Qtd];
        int i = 0;
        foreach (Personagem p in Perso.Listar())
        {
          aux1[i] = p;
          i++;
        }
        Array.Sort(aux1);
        int contador1 = 0;
        foreach (Personagem p in aux1)
        {
          Console.WriteLine($"[{contador1+1}] {p.Nome}");
          contador1++;
        }
        Console.WriteLine("[99] Voltar");
        Console.WriteLine();
        Console.WriteLine("Digite:");
    
        int EscolhaPersonagem = int.Parse(Console.ReadLine());
        if ( EscolhaPersonagem == 99)
        {
          Console.WriteLine();
        }
        else
        {
          if ( EscolhaPersonagem > contador1 || EscolhaPersonagem < 1)
          {
            Console.WriteLine("Valor Inválido");
            MenuPrincipalPersonagem(Perso, a);
          }
          else
          {
            MenuSubPersonagem(aux1[EscolhaPersonagem - 1], a, Perso);
          }
        }
        
        

        
  }
  static public void MenuSubPersonagem(Personagem p, Colecao<Artefato> a, Colecao<Personagem> Perso)
  {
        Console.WriteLine("[0] Mostrar");
        Console.WriteLine("[1] Artefatos");
        Console.WriteLine("[2] Materiais de Level");
        Console.WriteLine("[3] Tabela (Em desenvolvimento)");
        Console.WriteLine("[4] Excluir");
        Console.WriteLine("[5] Mudar Dados");
        Console.WriteLine("[99] Voltar");

        Console.WriteLine();
        Console.WriteLine("Digite:");
        int MenuPersonagem = int.Parse(Console.ReadLine());
        
        if (MenuPersonagem == 0)
        {
          Console.WriteLine(p);
          MenuSubPersonagem(p, a, Perso);
        }
        else {
          if (MenuPersonagem == 1)
          {
            MenuArtPersonagem(p, a, Perso);
          }
          else {
            if (MenuPersonagem == 2)
            {
            p.MoraXp();
            MenuSubPersonagem(p, a, Perso);
            }
            else
            {
              if (MenuPersonagem ==  4)
              {
                Perso.Excluir(p);
              }
              else
              {
                if (MenuPersonagem == 5)
                {
                  Personagem aux = new Personagem();
                  aux.Cadastrar();
                  aux.PersonagemArtefato("Flor", a, 0);
                  aux.PersonagemArtefato("Pena", a, 1);
                  aux.PersonagemArtefato("Relogio", a, 2);
                  aux.PersonagemArtefato("Calice", a, 3);
                  aux.PersonagemArtefato("Tiara", a, 4);
                  Perso.Inserir(aux);
                  Perso.Excluir(p);
                  MenuPrincipalPersonagem(Perso, a);
                }
                else
                {
                  if (MenuPersonagem == 99)
                  {
                    MenuPrincipalPersonagem(Perso, a);
                  }
                  else
                  {
                    Console.WriteLine("Valor Inválido");
                    MenuSubPersonagem(p, a, Perso);
                  }
                }
              }
            }
          }
        }
        
        
        
        
        
  }
  static public void MenuArtefatos(Colecao<Artefato> Artefa)
  {
        Console.WriteLine("===============================");
        Console.WriteLine("            Artefatos");
        Console.WriteLine("===============================");
        Console.WriteLine();

        Console.WriteLine("[0] TUDO");
        Console.WriteLine("[1] FLOR");
        Console.WriteLine("[2] PENA");
        Console.WriteLine("[3] RELOGIO");
        Console.WriteLine("[4] CALICE");
        Console.WriteLine("[5] TIARA");
        Console.WriteLine("[99] Menu");
        
        Console.WriteLine();
        Console.WriteLine("Digite:");
        int status = int.Parse(Console.ReadLine());
        Console.WriteLine();
    
        int contador = 0;
        if (status == 0)
        {
          int aux0 = 1;
          foreach (Artefato a in Artefa.Listar())
          {
            Console.WriteLine($"[{aux0}] {a}");
            aux0++;
          }
          Console.WriteLine("Digite:");
          int MenuA = int.Parse(Console.ReadLine());
          
          foreach (Artefato a in Artefa.Listar())
          {
            contador++;
            if (contador == MenuA)
            {
              Console.WriteLine("===============================");
              Console.WriteLine("[0] Excluir");
              Console.WriteLine("[1] Mostrar");
              Console.WriteLine("[2] Alterar Dados");
              Console.WriteLine("[99] Voltar");
              Console.WriteLine();
              Console.WriteLine("Digite:");
              int AuxMenuA = int.Parse(Console.ReadLine());

              if (AuxMenuA == 0)
              {
                Artefa.Excluir(a);
              }
              else
              {
                if (AuxMenuA == 1)
                {
                  Console.WriteLine(a);
                  
                }
                else
                {
                  if (AuxMenuA == 2)
                  {
                    a.CadastrarArtefato();
                  }
                  else
                  {
                    MenuArtefatos(Artefa);
                  }
                }
              }
              
            }
          }
          MenuArtefatos(Artefa);
        }
        if (status == 1)
        {
          int aux1 = 0;
          foreach (Artefato a in Artefa.Listar())
          {
            if ( a.Type == "Flor") 
            {
              Console.WriteLine($"[{aux1+1}] {a}");
              aux1++;
            }
          }
          MenuArtefatos(Artefa);
        }
        if (status == 2)
        {
          int aux2 = 0;
          foreach (Artefato a in Artefa.Listar())
          {
            if ( a.Type == "Pena") 
            {
              Console.WriteLine($"[{aux2+1}] {a}");
              aux2++;
            }
          }
          MenuArtefatos(Artefa);
        }
        if (status == 3)
        {
                            
          int aux3 = 0;
          foreach (Artefato a in Artefa.Listar())
          {
            if ( a.Type == "Relogio") 
            {
              Console.WriteLine($"[{aux3+1}] {a}");
              aux3++;
            }
          }
          MenuArtefatos(Artefa);;
        }
        if (status == 4)
        {
          int aux4 = 0;
          foreach (Artefato a in Artefa.Listar())
          {
            if ( a.Type == "Calice") 
            {
              Console.WriteLine($"[{aux4+1}] {a}");
              aux4++;
            }
          }
          MenuArtefatos(Artefa);
        }
        if (status == 5)
        {
          int aux5 = 0;
          foreach (Artefato a in Artefa.Listar())
          {
            if ( a.Type == "Tiara") 
            {
              Console.WriteLine($"[{aux5+1}] {a}");
              aux5++;
            }
          }
          MenuArtefatos(Artefa);
        }
        if (status == 99)
        {
          Menu();
        }
        else
        {
          Console.WriteLine("Valor Inválido");
          MenuArtefatos(Artefa);
        }
  }
  public static void MenuArtPersonagem(Personagem p, Colecao<Artefato> a, Colecao<Personagem> Perso)
  {
          Console.WriteLine("[0] Mostrar");
          Console.WriteLine("[1] Flor");
          Console.WriteLine("[2] Pena");
          Console.WriteLine("[3] Calice");
          Console.WriteLine("[4] Relogio");
          Console.WriteLine("[5] Tiara");
          Console.WriteLine("[99] Voltar");

          Console.WriteLine();
          Console.WriteLine("Digite:");
          int MenuAP = int.Parse(Console.ReadLine());
          Console.WriteLine("===============================");

          if ( MenuAP == 0 )
          {
            Console.WriteLine(p.Flor);
            Console.WriteLine(p.Pena);
            Console.WriteLine(p.Relogio);
            Console.WriteLine(p.Calice);
            Console.WriteLine(p.Tiara);
            MenuArtPersonagem(p, a, Perso);
          }
          if ( MenuAP == 1 )
          {
            MenuSubArtPersonagem( p, p.Flor, a, 0, Perso);
            
          }
          if ( MenuAP == 2 )
          {
            MenuSubArtPersonagem( p, p.Pena, a, 1, Perso);
            
          }
          if ( MenuAP == 3 )
          {
            MenuSubArtPersonagem( p, p.Calice, a, 3, Perso);
            
          }
          if ( MenuAP == 4 )
          {
            MenuSubArtPersonagem( p, p.Relogio, a, 2, Perso);
            
          }
          if ( MenuAP == 5 )
          {
            MenuSubArtPersonagem( p, p.Tiara, a, 4, Perso);
            
          }
          if ( MenuAP == 99 )
          {
            MenuSubPersonagem( p, a, Perso);
          }
          else
          {
            Console.WriteLine("Valor Inválido");
            MenuArtPersonagem(p, a, Perso);
          }
  }
  public static void MenuSubArtPersonagem(Personagem p, Artefato a, Colecao<Artefato> Art, int x, Colecao<Personagem> Perso)
  {
    Console.WriteLine($"{a.Type} ->");
    Console.WriteLine("[0] Mostrar");
    Console.WriteLine("[1] Trocar");
    Console.WriteLine("[99] Voltar");

    Console.WriteLine();
    Console.WriteLine("Digite:");
    int auxSAP = int.Parse(Console.ReadLine());
    Console.WriteLine("===============================");
    
    if ( auxSAP == 0)
    {
      Console.WriteLine(a);
      MenuSubArtPersonagem(p, a, Art, x, Perso);
    }
    if ( auxSAP == 1 )
    {
      p.PersonagemArtefato( a.Type, Art, x);
      if ( a.Type == "Flor" )
      {
        a = p.Flor;
      }
      if ( a.Type == "Pena" )
      {
        a = p.Pena;
      }
      if ( a.Type == "Calice" )
      {
        a = p.Calice;
      }
      if ( a.Type == "Relogio" )
      {
        a = p.Relogio;
      }
      if ( a.Type == "Tiara" )
      {
        a = p.Tiara;
      }
      MenuSubArtPersonagem(p, a, Art, x, Perso);
    }
    if ( auxSAP == 99 )
    {
      MenuArtPersonagem( p, Art, Perso);
    }
  }
  /*static void MenuSubArtefato(string Tipo, Colecao<Artefato> Arte)
  {
    foreach (Artefato a in Arte.Listar())
    {
      if ( a.Type == Tipo) 
      {
        Console.WriteLine($"[{aux2+1}] {a}");
        aux2++;
      }
    }
    MenuArtefatos(Artefa);
  } */
}
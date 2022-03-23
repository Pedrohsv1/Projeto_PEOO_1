using System;
using System.Collections;
using System.Collections.Generic;


class main
{
  static void Main()
  {
    
    Console.WriteLine("Texto normal de novo");
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

    Artefatos.Inserir(Arte2);
    Artefatos.Inserir(Arte3);
    Artefatos.Inserir(Arte4);
    Artefatos.Inserir(Arte5);

    Console.Clear();
    while (run != 0)
    {
      run = -1;
      while(run == -1) 
      {
        run = Menu();
      }
      
      if (run == 1)
      {
        Personagem aux = new Personagem();
        
        try
        {
          Console.Clear();
          aux.Cadastrar();
          Console.WriteLine();
          Console.WriteLine("Artefatos =====================");
          aux.PersonagemArtefato("Flor", Artefatos, 0);
          aux.PersonagemArtefato("Pena", Artefatos, 1);
          aux.PersonagemArtefato("Relogio", Artefatos, 2);
          aux.PersonagemArtefato("Calice", Artefatos, 3);
          aux.PersonagemArtefato("Tiara", Artefatos, 4);
          Console.Clear();
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("Personagem Cadastrado!");
          Console.ResetColor();
          Console.WriteLine();
        }
        catch (Exception)
        {
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.WriteLine("===============================");
          Console.ResetColor();
          
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("Erro, Tente denovo.");
          Console.ResetColor();
        }       
        Lista_Personagens.Inserir(aux);
      }
      if (run == 2)
      {  
        Console.Clear();
        Artefato aux0 = new Artefato();
        aux0.CadastrarArtefato();
        Artefatos.Inserir(aux0);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Artefato Cadastrado!");
        Console.ResetColor();
        Console.WriteLine();
      }
      if (run == 3)
      {
        Console.Clear();
        MenuPrincipalPersonagem(Lista_Personagens, Artefatos);
      }
      if (run == 4)
      {
        Console.Clear();
        MenuArtefatos(Artefatos);
      }
      if (run == 0)
      {
        Console.WriteLine("VAI SAIR MESMO? otario boe.");
      }
      
    }
  }
  static public int Menu()
  {
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("===============================");
      Console.ResetColor();
      Console.WriteLine("              Menu");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("===============================");
      Console.ResetColor();
      Console.WriteLine();
      Console.WriteLine("[1] Cadastrar Personagem");
      Console.WriteLine("[2] Cadastrar Artefato");
      Console.WriteLine("[3] Listar Personagens");
      Console.WriteLine("[4] Listar Artefatos");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("[0] Sair");
      Console.ResetColor();
      Console.WriteLine();
      Console.WriteLine("Digite:");
      int M = -1;
      try
      {
        M = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("===============================");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Erro, Tente denovo.");
        Console.ResetColor();
      }
      if (M != -1)
      {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("===============================");
        Console.ResetColor();
      }
      
      return M;
  }
  static public void MenuPrincipalPersonagem(Colecao<Personagem> Perso, Colecao<Artefato> a)
  {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("===============================");
        Console.ResetColor();
        Console.WriteLine("            Personagens");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("===============================");
        Console.ResetColor();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("[0] Voltar ao MENU");
        Console.ResetColor();
        Console.WriteLine();
    
        int EscolhaPersonagem = -1;
        while (EscolhaPersonagem < 0)
        {
          try
          {
            Console.WriteLine("Digite:");
            EscolhaPersonagem = int.Parse(Console.ReadLine());
            if (EscolhaPersonagem < 0 || EscolhaPersonagem > i)
            {
              Console.WriteLine();
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("Valor Inválido");
              Console.ResetColor();
              Console.WriteLine();
              EscolhaPersonagem = -1;
            }
          }
          catch (Exception)
          {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Erro, Tente denovo.");
            Console.ResetColor();
            Console.WriteLine();
          }
        }
        

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("===============================");
        Console.ResetColor(); 
    
        if ( EscolhaPersonagem == 0)
        {
          Console.Clear();
          Console.WriteLine();
        }
        else
        {
          Console.Clear();
          MenuSubPersonagem(aux1[EscolhaPersonagem - 1], a, Perso);

        }
          
  }
  static public void MenuSubPersonagem(Personagem p, Colecao<Artefato> a, Colecao<Personagem> Perso)
  {     
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Personagem: {p.Nome}");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("[1] Mostrar");
        Console.WriteLine("[2] Artefatos");
        Console.WriteLine("[3] Materiais de Level");
        Console.WriteLine("[4] Tabela (Em desenvolvimento)");
        Console.WriteLine("[5] Excluir");
        Console.WriteLine("[6] Mudar Dados");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("[0] Voltar");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Digite:");
        int MenuPersonagem = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("===============================");
        Console.ResetColor();
        
        if (MenuPersonagem == 1)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("===============================");
          Console.ResetColor();
          Console.WriteLine();
          Console.WriteLine(p);
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("===============================");
          Console.ResetColor();
          MenuSubPersonagem(p, a, Perso);
        }
        else {
          if (MenuPersonagem == 2)
          {
            MenuArtPersonagem(p, a, Perso);
          }
          else {
            if (MenuPersonagem == 3)
            {
              Console.Clear();
              p.MoraXp();
              MenuSubPersonagem(p, a, Perso);
            }
            else
            {
              if (MenuPersonagem ==  5)
              {
                Perso.Excluir(p);
              }
              else
              {
                if (MenuPersonagem == 6)
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
                  if (MenuPersonagem == 0)
                  {
                    Console.Clear();
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
        Console.Clear();
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
              Console.WriteLine("===============================");
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
          Console.WriteLine();
        }
        else
        {
          Console.WriteLine("Valor Inválido");
          MenuArtefatos(Artefa);
        }
  }
  public static void MenuArtPersonagem(Personagem p, Colecao<Artefato> a, Colecao<Personagem> Perso)
  {
          Console.Clear();
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine($"Personagem: {p.Nome}");
          Console.ResetColor();
          Console.WriteLine();
          Console.WriteLine("[1] Mostrar");
          Console.WriteLine("[2] Flor");
          Console.WriteLine("[3] Pena");
          Console.WriteLine("[4] Calice");
          Console.WriteLine("[5] Relogio");
          Console.WriteLine("[6] Tiara");
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("[0] Voltar");
          Console.ResetColor();

          Console.WriteLine();
          Console.WriteLine("Digite:");
          int MenuAP = int.Parse(Console.ReadLine());
    
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("===============================");
          Console.ResetColor();

          if ( MenuAP == 1 )
          {
            Console.WriteLine(p.Flor);
            Console.WriteLine(p.Pena);
            Console.WriteLine(p.Relogio);
            Console.WriteLine(p.Calice);
            Console.WriteLine(p.Tiara);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===============================");
            Console.ResetColor();
            MenuArtPersonagem(p, a, Perso);

          }
          if ( MenuAP == 2)
          {
            if (p.Flor == null)
            {
              Console.WriteLine("Você ainda não tem uma Flor escolha uma:");
              p.PersonagemArtefato("Flor", a, 0);
              Console.Clear();
              MenuArtPersonagem(p, a, Perso);
            }
            else
            {
              Console.Clear();
              MenuSubArtPersonagem( p, p.Flor, a, 0, Perso);
            }      
            Console.WriteLine();
          }
          else
          {
            if ( MenuAP == 3)
            {
              if (p.Pena == null)
              {
                Console.WriteLine("Você ainda não tem uma Pena escolha uma:");
                p.PersonagemArtefato("Pena", a, 1);
                Console.Clear();
                MenuArtPersonagem(p, a, Perso);
              }
              else
              {
                Console.Clear();
                MenuSubArtPersonagem( p, p.Pena, a, 1, Perso);
              }
              Console.WriteLine();
            }
            else
            {
              if ( MenuAP == 4 )
              {
                if (p.Calice == null)
                {
                  Console.WriteLine("Você ainda não tem uma Cálice escolha um:");
                  p.PersonagemArtefato("Calice", a, 3);
                  Console.Clear();
                  MenuArtPersonagem(p, a, Perso);
                }
                else
                {
                  Console.Clear();
                  MenuSubArtPersonagem( p, p.Calice, a, 3, Perso);
                }
                Console.WriteLine();
              }
              else
              {
                if ( MenuAP == 5 )
                {
                  if (p.Relogio == null)
                  {
                    Console.WriteLine("Você ainda não tem uma Relogio escolha um:");
                    p.PersonagemArtefato("Relogio", a, 2);
                    Console.Clear();
                    MenuArtPersonagem(p, a, Perso);
                  }
                  else
                  {
                    Console.Clear();
                    MenuSubArtPersonagem( p, p.Relogio, a, 2, Perso);
                  }
                  Console.WriteLine();
                  
                }
                else
                {
                  if ( MenuAP == 6 )
                  {
                    if (p.Tiara == null)
                    {
                      Console.WriteLine("Você ainda não tem uma Tiara escolha um:");
                      p.PersonagemArtefato("Tiara", a, 4);
                      Console.Clear();
                      MenuArtPersonagem(p, a, Perso);
                    }
                    else
                    {
                      Console.Clear();
                      MenuSubArtPersonagem( p, p.Tiara, a, 4, Perso);
                    }
                    Console.WriteLine();
                  }
                  else
                  {
                    if ( MenuAP == 0 )
                    {
                      Console.Clear();
                      MenuSubPersonagem( p, a, Perso);
                    }
                    else
                    {
                      Console.ForegroundColor = ConsoleColor.DarkRed;
                      Console.WriteLine("Valor Inválido");
                      Console.ResetColor();
                      Console.Clear();
                      MenuArtPersonagem(p, a, Perso);
                    }
                  }
                }
              }
            }
          }
          
          
          
          
          
          
  }
  public static void MenuSubArtPersonagem(Personagem p, Artefato a, Colecao<Artefato> Art, int x, Colecao<Personagem> Perso)
  {
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{p.Nome} - {a.Type}");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("[1] Mostrar");
    Console.WriteLine("[2] Trocar");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("[0] Voltar");
    Console.ResetColor();

    Console.WriteLine();
    Console.WriteLine("Digite:");
    int auxSAP = int.Parse(Console.ReadLine());
    
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("===============================");
    Console.ResetColor();
    
    if ( auxSAP == 1)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();
      Console.WriteLine(a);
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();

      MenuSubArtPersonagem(p, a, Art, x, Perso);
    }
    
    if ( auxSAP == 2 )
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();
      p.PersonagemArtefato( a.Type, Art, x, true);
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
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();
      MenuSubArtPersonagem(p, a, Art, x, Perso);
    }
    if ( auxSAP == 0 )
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();
      Console.Clear();
      MenuArtPersonagem( p, Art, Perso);
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Erro, Tente denovo.");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("===============================");
      Console.ResetColor();
      Console.Clear();
      MenuSubArtPersonagem(p, a, Art, x, Perso);
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
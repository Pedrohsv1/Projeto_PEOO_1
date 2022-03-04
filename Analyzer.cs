using System;
using System.Collections;
using System.Collections.Generic;

class main
{
  static void Main()
  {
    Console.WriteLine("===============");
    Console.WriteLine("Anlyzer Genshin");
    Console.WriteLine("===============");
    Console.WriteLine();
    Artefato Arte1 = new Artefato{Name = "Trupe Itinerante", Type = "Flor", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte2 = new Artefato{Name = "Trupe Itinerante", Type = "Relogio", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG", ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte3 = new Artefato{Name = "Trupe Itinerante", Type = "Tiara", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte4 = new Artefato{Name = "Trupe Itinerante", Type = "Pena", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};

    Artefato Arte5 = new Artefato{Name = "Trupe Itinerante", Type = "Calice", MainStatus = "FLAT HP", Status_1 = "HP%", Status_2 = "ATQ%",Status_3 = "CRIT RATE",Status_4 = "CRIT DMG",ValueMainStatus = 46, ValueStatus_1 = 10, ValueStatus_2 = 8.7, ValueStatus_3 = 12.5, ValueStatus_4 = 6.3,};


    Personagem Childe = new Personagem{Nome = "Tartaglia", Level = 90, Type = "Hydro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};

    Personagem Hu = new Personagem{Nome = "Hu Tao", Level = 90, Type = "Pyro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};
    
    Personagem Ayaka = new Personagem{Nome = "Ayaka", Level = 90, Type = "Cryo", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};
    
    Personagem Mona = new Personagem{Nome = "Mona", Level = 90, Type = "Hydro", Flor = Arte1, Pena = Arte4, Relogio = Arte2, Tiara = Arte3, Calice = Arte5};

    Colecao<Personagem> Lista_Personagens = new Colecao<Personagem>();

    Lista_Personagens.Inserir(Childe);
    Lista_Personagens.Inserir(Hu);
    Lista_Personagens.Inserir(Ayaka);
    Lista_Personagens.Inserir(Mona);

    foreach (Personagem p in Lista_Personagens.Listar())
    {
      Console.WriteLine(p);
    }
    
  }
}
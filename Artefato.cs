using System;
using System.Collections;
using System.Collections.Generic;


class Artefato
{
  public string Name { get ; set;}
  public string Type { get ; set; }
  public string MainStatus { get ; set; }
  public string Status_1 { get ; set; }
  public string Status_2 { get ; set; }
  public string Status_3 { get ; set; }
  public string Status_4 { get ; set; }
  public double ValueMainStatus { get ; set; }
  public double ValueStatus_1 { get ; set; }
  public double ValueStatus_2 { get ; set; }
  public double ValueStatus_3 { get ; set; }
  public double ValueStatus_4 { get ; set; }

  public override string ToString()
  {
    return $"
    {Type} | {Name}
  
    {MainStatus} - {ValueMainStatus}

    {Status_1} - {ValueStatus_1}
    {Status_2} - {ValueStatus_2}
    {Status_3} - {ValueStatus_3}
    {Status_4} - {ValueStatus_4}
    ";
  }
  public void CadastrarArtefato()
  {
    Console.WriteLine("Informaçoes do seu Artefato:");
    
    Console.Write("Nome: ");
    this.Name = Console.ReadLine();
    Console.WriteLine();
    
    Console.WriteLine("Digite para o tipo:\n[1] Flor\n[2] Pena\n[3] Relogio\n[4] Cálice\n[5] Tiara");
    Console.Write("Digite: ");
    int TypeC = int.Parse(Console.ReadLine());
    if (TypeC == 1) Type = "Flor";
    if (TypeC == 2) Type = "Pena";
    if (TypeC == 3) Type = "Relogio";
    if (TypeC == 4) Type = "Calice";
    if (TypeC == 5) Type = "Tiara";
    Console.WriteLine();

    if (Type == "Flor") this.MainStatus = "FLAT HP";
    else
    {
      if (Type == "Pena") this.MainStatus = "FLAT ATQ";
      else
      {
        Console.WriteLine("Main Status: \n[1] HP%\n[2] ATQ%\n[3] DEF%\n[4] CRIT RATE\n[5] CRIT DMG\n[6] EM\n[7] Elemental DMG%\n[8] Healing Bonus%\n[9] Energy Recharge%");
        Console.WriteLine();
        Console.Write("Digite: ");
        int MainStatusC = int.Parse(Console.ReadLine());
        if (MainStatusC == 1) MainStatus = "HP%";
        if (MainStatusC == 2) MainStatus = "ATQ%";
        if (MainStatusC == 3) MainStatus = "DEF%";
        if (MainStatusC == 4) MainStatus = "CRIT RATE";
        if (MainStatusC == 5) MainStatus = "CRIT DMG";
        if (MainStatusC == 6) MainStatus = "EM";
        if (MainStatusC == 7) MainStatus = "Elemental DMG%";
        if (MainStatusC == 8) MainStatus = "Healing Bonus%";
        if (MainStatusC == 9) MainStatus = "Energy Recharge%";
      }
    }
    Console.WriteLine("SubStatus 1: \n[1] HP%\n[2] ATQ%\n[3] DEF%\n[4] CRIT RATE\n[5] CRIT DMG\n[6] EM\n[7] FLAT ATQ\n[8] FLAT HP\n[9] FLAT DEF");
    Console.WriteLine();
    Console.Write("Digite: ");
    int SubStatus1 = int.Parse(Console.ReadLine());
    if (SubStatus1 == 1) Status_1 = "HP%";
    if (SubStatus1 == 2) Status_1 = "ATQ%";
    if (SubStatus1 == 3) Status_1 = "DEF%";
    if (SubStatus1 == 4) Status_1 = "CRIT RATE";
    if (SubStatus1 == 5) Status_1 = "CRIT DMG";
    if (SubStatus1 == 6) Status_1 = "EM";
    if (SubStatus1 == 7) Status_1 = "FLAT HP";
    if (SubStatus1 == 8) Status_1 = "FLAT ATQ";
    if (SubStatus1 == 9) Status_1 = "FLAT DEF";
    Console.WriteLine("SubStatus 2: \n[1] HP%\n[2] ATQ%\n[3] DEF%\n[4] CRIT RATE\n[5] CRIT DMG\n[6] EM\n[7] FLAT ATQ\n[8] FLAT HP\n[9] FLAT DEF");
    Console.WriteLine();
    Console.Write("Digite: ");
    int SubStatus2 = int.Parse(Console.ReadLine());
    if (SubStatus2 == 1) Status_2 = "HP%";
    if (SubStatus2 == 2) Status_2 = "ATQ%";
    if (SubStatus2 == 3) Status_2 = "DEF%";
    if (SubStatus2 == 4) Status_2 = "CRIT RATE";
    if (SubStatus2 == 5) Status_2 = "CRIT DMG";
    if (SubStatus2 == 6) Status_2 = "EM";
    if (SubStatus2 == 7) Status_2 = "FLAT HP";
    if (SubStatus2 == 8) Status_2 = "FLAT ATQ";
    if (SubStatus2 == 9) Status_2 = "FLAT DEF";
    Console.WriteLine("SubStatus 3: \n[1] HP%\n[2] ATQ%\n[3] DEF%\n[4] CRIT RATE\n[5] CRIT DMG\n[6] EM\n[7] FLAT ATQ\n[8] FLAT HP\n[9] FLAT DEF");
    Console.WriteLine();
    Console.Write("Digite: ");
    int SubStatus3 = int.Parse(Console.ReadLine());
    if (SubStatus3 == 1) Status_3 = "HP%";
    if (SubStatus3 == 2) Status_3 = "ATQ%";
    if (SubStatus3 == 3) Status_3 = "DEF%";
    if (SubStatus3 == 4) Status_3 = "CRIT RATE";
    if (SubStatus3 == 5) Status_3 = "CRIT DMG";
    if (SubStatus3 == 6) Status_3 = "EM";
    if (SubStatus3 == 7) Status_3 = "FLAT HP";
    if (SubStatus3 == 8) Status_3 = "FLAT ATQ";
    if (SubStatus3 == 9) Status_3 = "FLAT DEF";
    Console.WriteLine("SubStatus 4: \n[1] HP%\n[2] ATQ%\n[3] DEF%\n[4] CRIT RATE\n[5] CRIT DMG\n[6] EM\n[7] FLAT ATQ\n[8] FLAT HP\n[9] FLAT DEF");
    Console.WriteLine();
    Console.Write("Digite: ");
    int SubStatus4 = int.Parse(Console.ReadLine());
    if (SubStatus4 == 1) Status_4 = "HP%";
    if (SubStatus4 == 2) Status_4 = "ATQ%";
    if (SubStatus4 == 3) Status_4 = "DEF%";
    if (SubStatus4 == 4) Status_4 = "CRIT RATE";
    if (SubStatus4 == 5) Status_4 = "CRIT DMG";
    if (SubStatus4 == 6) Status_4 = "EM";
    if (SubStatus4 == 7) Status_4 = "FLAT HP";
    if (SubStatus4 == 8) Status_4 = "FLAT ATQ";
    if (SubStatus4 == 9) Status_4 = "FLAT DEF";

    Console.WriteLine();

    Console.Write("Valor Main Status: ");
    this.ValueMainStatus = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write($"Valor SubStatus 1 {Status_1}: ");
    this.ValueStatus_1 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write($"Valor SubStatus 2 {Status_2}: ");
    this.ValueStatus_2 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write($"Valor SubStatus 1 {Status_3}: ");
    this.ValueStatus_3 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write($"Valor SubStatus 1 {Status_4}: ");
    this.ValueStatus_4 = double.Parse(Console.ReadLine());
  }
  
}
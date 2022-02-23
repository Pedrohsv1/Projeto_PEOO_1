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
  public string Status_5 { get ; set; }
  public double ValueStatus_1 { get ; set; }
  public double ValueStatus_2 { get ; set; }
  public double ValueStatus_3 { get ; set; }
  public double ValueStatus_4 { get ; set; }
  public double ValueStatus_5 { get ; set; }

  public override string ToString()
  {
    return $"
    {Type} | {Name}
  
    {MainStatus}

    {Status_1} - {ValueStatus_1}
    {Status_2} - {ValueStatus_2}
    {Status_3} - {ValueStatus_3}
    {Status_4} - {ValueStatus_4}
    ";
  }
}
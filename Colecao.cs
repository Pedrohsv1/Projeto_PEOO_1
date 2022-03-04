using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Colecao<T>
{
  private List<T> lista = new List<T>();
  public int Qtd { get => lista.Count; }

  public void Inserir(T i)
  {
    lista.Add(i);
  }
  public void Excluir(T i)
  {
    lista.Remove(i);
  }
  public List<T> Listar()
  {
    return lista;
  }
  public T[] BuscarArtefato(string status)
  {
    int i = 0;
    foreach (T a in lista)
    {
      if (a.MainStatus == status)
      {
        i++;
      }    
    }
    T[] aux = new T[i];

    int c = 0;
    foreach (T a in lista)
    {
      if (a.MainStatus == status)
      {
        aux[c] = a;
        c++;
      }
    }
  }
}
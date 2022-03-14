using System;
using System.Collections;
using System.Collections.Generic;


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
}
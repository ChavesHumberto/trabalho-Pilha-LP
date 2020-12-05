using System;
using System.Collections.Generic;

public class Pilha {
  public static int TAM_MAX = 1000;
  private List<int> valores;
  private int topo;

    public Pilha(){
      this.topo = -1;
      this.valores = new List<int>();
    }

    public bool empty(){
      if( this.topo == -1) return true;
      else return false;
    }

    public void push(int n){
      if(this.valores.Count < Pilha.TAM_MAX){
      this.valores.Add(n);
      this.topo = n;
      }
    }

    public int top(){
      return this.topo;
    }

    public void pop(){
      int x = this.valores.Count;
      if(x > 0){
        this.valores.RemoveAt(x-1);
        if(x==1)
          this.topo = -1;
        else
          this.topo = valores[x-2];
      }
    }

    public void pop(int n){
      for(int i=0;i<n;i+=1){
        this.pop();
      }
    }

    public void lt(){
      foreach (int element in this.valores){
        Console.WriteLine(element);
      }
    }
}

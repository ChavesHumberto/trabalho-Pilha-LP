using System;
using System.Collections.Generic;

public class Pilha {
  public static int TAM_MAX = 1000;
  private List<object> valores;
  private object topo;

    public Pilha(){
      this.topo = null;
      this.valores = new List<object>();
    }

    public bool empty(){
      if( this.topo == null) return true;
      else return false;
    }

    public void push(object n){
      if(this.valores.Count < Pilha.TAM_MAX){
      this.valores.Add(n);
      this.topo = n;
      }
    }

    public object top(){
      return this.topo;
    }

    public void pop(){
      int x = this.valores.Count;
      if(x > 0){
        this.valores.RemoveAt(x-1);
        if(x==1)
          this.topo = null;
        else
          this.topo = valores[x-2];
      }
    }

    public void pop(int n){
      for(int i=0;i<n;i+=1){
        this.pop();
      }
    }

}

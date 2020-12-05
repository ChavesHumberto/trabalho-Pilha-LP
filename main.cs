using System;


class MainClass {
  public static void Main (string[] args) {
    Pilha p = new Pilha();
    Console.WriteLine(p.empty());
    Console.WriteLine(p.top());
    p.push(10);
    p.push(20);
    p.push(30);
    p.push(40);
    p.lt();
    Console.WriteLine("\n");
    Console.WriteLine(p.top());
    Console.WriteLine("\n");
    p.pop();
    Console.WriteLine("\n");
    Console.WriteLine(p.top());
    Console.WriteLine("\n");
    p.pop(2); 
    Console.WriteLine(p.top());
    
    Console.WriteLine("\n");
    p.pop(2); 
    Console.WriteLine(p.top());

  }
}

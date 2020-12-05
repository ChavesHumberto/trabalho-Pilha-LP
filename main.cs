using System;

public class car{
  public string name;
}
 
class MainClass {
  public static void Main (string[] args) {
    Pilha p = new Pilha();
    Console.WriteLine(p.empty());
    if(p.top()==null)
      Console.WriteLine("null");
    

    car c = new car();
    c.name = "relampago";

    car d = new car();
    d.name = "mate";

    car e = new car();
    e.name = "velinho";

    p.push(c);
    p.push(d);
    p.push(e);
    
    car x = new car();
    p.pop(2);
    x = (car)p.top();

    Console.WriteLine(x.name);
    Console.WriteLine(p.empty());


  }
}

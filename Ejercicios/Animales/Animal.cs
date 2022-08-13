public class Animal 
{
 public string Nombre { get; set; }

public Animal(){
    Nombre = "";
}

 public void Comer()
 {
  Console.WriteLine("Los animales comen");
  
 }

}
public class Peces: Animal
{

public int Numaletas { get; set; }
public Aletas(){
    Numaletas = "";
}

public void nadar(){
    Console.WriteLine("Los peces saben nadar");
}

}
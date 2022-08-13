public class Aves: Animal
{

public string colorplumaje { get; set; }

public Aves(){
    colorplumaje = "";
}

public void Volar(){
    Console.WriteLine("Las aves vuelan");
}

}
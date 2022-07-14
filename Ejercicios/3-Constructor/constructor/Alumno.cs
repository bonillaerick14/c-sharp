public class Alumno
{
public int id { get; set; }
public string PrimerNombre { get; set; }
public string SegundoNombre { get; set; }

public Alumno()
 {
 id = 1;

}
public Alumno( int Id)
 {
 id = Id;
}

public Alumno(string primerNombre, string segundoNombre)
{
PrimerNombre = primerNombre;
SegundoNombre = segundoNombre;
}

}
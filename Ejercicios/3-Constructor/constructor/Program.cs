using System;

namespace holamundo
{
  class Program
  {

   static void Main(string[] args)

   {
    Alumno a = new Alumno();
    
    a.PrimerNombre = "Juan";
    a.SegundoNombre = "Perez";

    Alumno b = new Alumno();
    b.id = 2;
    b.PrimerNombre = "Maria";
    b.SegundoNombre = ",Martinez";

    Alumno d = new Alumno("Juan", "Jimenez");


    Alumno c = new Alumno (3);
    b.PrimerNombre = "Pedro";

    Console.WriteLine(a.id);
    Console.WriteLine(b.id);
    Console.WriteLine(c.id);
    Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
   }


  }


}
//Length

String cadena1 = "Hola, como estan? Yo muy bien gracias";
int cantcadena = cadena1.Length;
Console.WriteLine(cantcadena);

//ToUpper ToLower

String mayus = "HOLA COMO ESTAN";
String minus = "me gusta comer panes";
String mayusm = mayus.ToLower();
String minusm = minus.ToUpper();
Console.WriteLine(mayus);
Console.WriteLine(minus);
Console.WriteLine(mayusm);
Console.WriteLine(minusm);

//IndexOf LastIndexOf

String busqueda = "Quiero buscar la letra a";
int buscar = busqueda.IndexOf('a');
Console.WriteLine(buscar);
int buscar1 = busqueda.LastIndexOf("a");
Console.WriteLine(buscar1);

//Substrac

String completa = "Voy a subtraer algo de esta cadena";
String parte  = completa.Substring(6,8);
Console.WriteLine(parte);

//Remplace

String original = "Hola me gusta mucho cocinar";
String remplazo = original.Replace("cocinar", "comer");
Console.WriteLine(original);
Console.WriteLine(remplazo);

//Trim

String espacio = "          Hola                ";
String sinespacio = espacio.Trim();
Console.WriteLine(sinespacio);
Console.WriteLine(espacio);

//StarsWhite LastWhite

String sipasa = "Si esta cadena tiene si sera verdadero";
if(sipasa.EndsWith("er"))
{
    Console.WriteLine("El texto si inicia");
}
else
{
    Console.WriteLine("El texto no inicia");
}

//String.Format

String nombre = "Marvin";
int edad = 18;
String inmutable = String.Format("Hola me llamo {0} y tengo {1} años",nombre,edad);
Console.WriteLine(inmutable);

//Equals

String igual1 = "Hola me llamo Marvin";
String igual2 = "Hola me llamo Marvin";
if (igual1.Equals(igual2)) 
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

//Char


String ejemplo = "Hola";
char ejem = ejemplo[0];
Console.WriteLine(ejem);

//Null

String nulo = "Ahora no esta vacia";
bool nulo1 = String.IsNullOrEmpty(nulo);
if(nulo1)
{
    Console.WriteLine("La cadena esta vacia");
}
else
{
    Console.WriteLine("La cadena contiene: " + nulo);
}

//Comparacion

String comp1 = "HOLA ME LLAMO MARVIN";
String comp2 = "hola me llamo marvin";
String comp1t = comp1.ToLower();
String comp2t = comp2.ToLower();
if(comp1t.Equals(comp2t))
{
    Console.WriteLine("Las cadenas con iguales");
}
else
{
    Console.WriteLine("Las cadenas son diferentes");
}

//Concatenacion

String parte1 = "Marvin";
String parte2 = " Cámbara";
String final = String.Concat(parte1, parte2);
Console.WriteLine("Usted se llama: " + final);

//Busqueda

String bucaremos = "Este, es un gran dia, para estar sentado";
String bucaremos1 = bucaremos.ToLower();
int indice = -1;
do
{
    indice = bucaremos.IndexOf("es", indice + 1);
    if(indice != -1 )
    {
        Console.WriteLine("La palabra se encuentra en el indice: "+ indice);
    }
}while(indice != -1);

//Formate

String nombre3 = Console.ReadLine();
int edad3 = 24;
String ciudad = "Jutiapa";
String muni = "Jalpatagua";
String totald = String.Format("Hola muy buenas tardes, me llamo {0} tengo {1} años vivo en el departamento de {2} municipio {3}",nombre3,edad3,ciudad,muni);
Console.WriteLine(totald);
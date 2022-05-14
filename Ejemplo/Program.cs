//string nombre = " ";
//Console.WriteLine(nombre.Length);

//if (string.IsNullOrWhiteSpace (nombre))
//{
//    Console.WriteLine("string vacio");
//}
//else
//{
//    Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCeros = "99";
//numeroConCeros = numeroConCeros.PadLeft( 3, '$');
//Console.WriteLine(numeroConCeros);


//string nombre = "Lady";
//string apellido = "Nuñez";
//int edad = 33;

//string nombreYEdad = nombre + "|" + apellido + "|" + edad;
//Console.WriteLine(nombreYEdad);


//string nombreYEdad = $"{nombre} | {apellido} | {edad}" ;
//Console.WriteLine(nombreYEdad);

//string numeroString = "5 Lady";
//int numeroInt = Convert.ToInt32 (numeroString);



//int numeroInt = int.Parse(numeroString); 
//Console.WriteLine(numeroInt);

//string numeroString = "5";
//int numeroInt = -1; 
//bool pudo = int.TryParse(numeroString, out numeroInt);
//Console.WriteLine(pudo);

string cadena = "Holamundo";
Console.WriteLine(cadena.IndexOf("a"));
using Newtonsoft.Json;

if (System.IO.File.Exists("name.json"))
{
    try
    {
        var json = System.IO.File.ReadAllText("name.json");
        //Chatbot.Name = JsonConvert.DeserializeObject<Chatbot.Name>(json);
    }
    catch (Exception)
    {
        Console.WriteLine("No se pudo leer el archivo");
    }
}
else
{
    Console.WriteLine("No se pudo encontrar el archivo");
}

bool continuar = true;

while(continuar == true){
    Console.Clear();
    Console.WriteLine(@"

                    _(\    |@@|
                   (__/\__ \--/ __
                      \___|----|  |  __
                          \ }{ /\ )_/ _\
                          /\__/\ \__O(__
                         (--/\--)   \__/
                         _)(  )(_
                        `---''---`
        BIENVENIDO AL ITLA, ¿QUÉ DESEA PREGUNTAR?
HAZME UNA PREGUNTA ACERCA DEL ITLA O ESCRIBE 'NO' PARA SALIR
    ");
    var seleccion = Console.ReadLine() ?? "";

    if(seleccion.ToLower() == "no"){
        continuar = false;
        Chatbot.saveName();
        Console.Clear();
        Console.WriteLine("Nos vemos pronto!");
    }
    else{
        var respuesta = Chatbot.Artificial(seleccion);
        Console.WriteLine(respuesta);
        Chatbot.saveName();
        Console.WriteLine("\nPresiona una tecla para continuar");
        Console.ReadKey();
    }
}

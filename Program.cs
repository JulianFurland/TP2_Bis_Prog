int opcion = -1;
Boxeador bx1 = null;
Boxeador bx2 = null;
while(opcion != 4)
{
    opcion = IngresarEntero("Ingrese la opcion que quiere ingresar\n1: Crear Boxeador 1\n2: Crear Boxeador 2\n3: Simular Pelea\n4: Salir");
    switch (opcion){
    case 1:
    bx1 = CrearBoxeador();
    break;
    case 2:
    bx2 = CrearBoxeador();
    break;
    case 3:
    if(bx1 == null ||bx2 == null){
        Console.WriteLine("No ingresaste ambos boxeadores todavía, ingresá primero antes de pelear");
        PresionaEnter();
    }
    else{
        Pelea(bx1, bx2);
        PresionaEnter();
    }
    break;
    case 4:
    break;
    default:
        opcion = IngresarEntero("Esa opcion no existe, volve a ingresar");
        PresionaEnter();
    break;
    }
    
}
static int IngresarEntero(string msj)
{
    Console.WriteLine(msj);
    return int.Parse(Console.ReadLine());
}
static string IngresarString(string msj){
    Console.WriteLine(msj);
    return Console.ReadLine();
}
static int IngresarEntero1A100(string msj)
{
    int num = IngresarEntero(msj);
    while( num > 100|| num < 1)
    {
        Console.WriteLine("Ese valor no es aduecuado, intente uno entre 1 y 100");
        num = IngresarEntero("");
    }
    return num;
}
static Boxeador CrearBoxeador(){
    string nombre = IngresarString("Nombre:");
    string pais = IngresarString("Pais:");
    int peso = IngresarEntero("Peso:");
    int potencia = IngresarEntero1A100("Potencia:");
    int velocidad = IngresarEntero1A100("Velocidad:");
    int inteligencia = IngresarEntero1A100("Inteligencia:");
    return new Boxeador(nombre, pais, peso, potencia,velocidad,inteligencia);
}
static void Pelea(Boxeador bx1, Boxeador bx2)
{
    Boxeador ganador = new Boxeador(); 
    double diff = bx1.ObtenerSkill() - bx2.ObtenerSkill();
    
    if(diff == 0){ 
        Console.WriteLine("La pelea terminó en empate");
    }
    else{
        if(diff > 0) ganador = bx1;
        else if (diff<0){
            ganador = bx2;
            diff = diff * -1;
        }    
        if(diff >= 30){
            Console.WriteLine("Ganó "+ganador.Nombre+ " por KO");
        }
        else if(diff >= 10){
            Console.WriteLine("Ganó "+ganador.Nombre+" por puntos en fallo unánime");
        }
        else if(diff <= 10){
            Console.WriteLine("Ganó "+ganador.Nombre+" por puntos en fallo dividido");
        }
    
    }
    
}
void PresionaEnter(){
    Console.WriteLine("Presiona Enter para seguir");
    Console.ReadLine();
    Console.Clear();
}
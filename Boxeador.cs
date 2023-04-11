class Boxeador{
    public string Nombre {get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    public int Inteligencia{get;set;}

public Boxeador()
{

}
public Boxeador(string nombre, string pais, int peso, int potencia, int velocidad, int inteligencia)
{
    Nombre = nombre;
    Pais = pais;
    Peso = peso;
    PotenciaGolpes = potencia;
    VelocidadPiernas = velocidad;
    inteligencia = Inteligencia;
}
public double ObtenerSkill()
{
    Random r = new Random();
    return (PotenciaGolpes*0.8) + (VelocidadPiernas * 0.6) + (Inteligencia * 0.25) + r.Next(1,11);
}
public void RandomizarStats(){
    Random r = new Random();
    VelocidadPiernas = r.Next(1,101);
    PotenciaGolpes = r.Next(1,101);
    Inteligencia = r.Next(1,101);
}
}
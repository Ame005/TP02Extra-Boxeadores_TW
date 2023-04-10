using System;
class Boxeador{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    
    public Boxeador(string nombre,string pais,int peso,int potGolpes,int velPiernas){
        Nombre=nombre;
        Pais=pais;
        Peso=peso;
        PotenciaGolpes=potGolpes;
        VelocidadPiernas=velPiernas;
    }
    public int ObtenerSkill(){
        int skill;
        Random r = new Random();
        skill=(VelocidadPiernas*0.6)+(PotenciaGolpes*0.8)+(r.Next(1,10));
        return skill;
    }
}
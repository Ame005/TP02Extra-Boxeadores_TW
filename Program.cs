internal class Program{
    private static void Main(string[] args){
        int eleccion=0,diferencia;
        Boxeador boxeador1=null,boxeador2=null;
        do{
            eleccion=menuEjercicio();
            switch(eleccion){
                case 1:
                boxeador1=ObtenerBoxeador();
                break;
                case 2:
                boxeador2=ObtenerBoxeador();
                break;
                case 3:
                if(boxeador1!=null&&boxeador2!=null){
                    skill1=boxeador1.ObtenerSkill();
                    skill2=boxeador2.ObtenerSkill();
                    if(skill1>skill2){
                        diferencia=skill1-skill2;
                        if(diferencia>=30)
                        Console.WriteLine("Ganó "+boxeador1.Nombre+" por KO");
                        else if(diferencia>10&&diferencia<30)
                        Console.WriteLine("Ganó "+boxeador1.Nombre+" por puntos en fallo unánime");
                        else
                        Console.WriteLine("Ganó "+boxeador1.Nombre+" por puntos en fallo dividido");
                    }
                    else if(skill2>skill1){
                        diferencia=skill2-skill1;
                        if(diferencia>=30)
                        Console.WriteLine("Ganó "+boxeador2.Nombre+" por KO");
                        else if(diferencia>10&&diferencia<30)
                        Console.WriteLine("Ganó "+boxeador2.Nombre+" por puntos en fallo unánime");
                        else
                        Console.WriteLine("Ganó "+boxeador2.Nombre+" por puntos en fallo dividido");
                    }
                    else
                    COnsole.WriteLine("Empate");
                }
                break;
            }
        }while(eleccion!=4);
    }
    static Boxeador ObtenerBoxeador(){
        string nombre,pais;
        int peso,potGolpes,velpiernas;
        nombre=IngresarString("Ingrese el nombre del Boxeador");
        pais=IngresarString("Ingresar el país del Boxeador");
        peso=IngresarInt("Ingrese el peso del Boxeador");
        potGolpes=IngresarIntEspecial("Ingrese la potencia de golpes del Boeador2");
        velPiernas=IngresarIntEspecial("Ingrese la velocidad de piernas del Boxeador");
        Boxeador boxeador=new Boxeador(nombre,pais,peso,potGolpes,velPiernas);
        Console.WriteLine("Se ha creado el boxeador "+nombre);
        return boxeador;
    }
    static int IngresarIntEspecial(string mensaje){
        int devolver;
        bool valido=false;
        do{
        Console.WriteLine(mensaje);
        devolver=int.Parse(Console.ReadLine());
        if(devolver>=1&&devolver<=100)
        valido=true;
        }while(!valido);  
        return devolver;
    }
    static string IngresarString(string mensaje){
        string devolver;
        Console.WriteLine(mensaje);
        devolver=Console.ReadLine();
        return devolver;
    }
    static void cambiarNom(Dictionary<int,Persona> dicPersonas, int ingresado){
        string nuevoNom;
        if (dicPersonas.ContainsKey(ingresado)){
            nuevoNom=IngresarString("Ingrese el nuevo nombre");
            dicPersonas[ingresado].Nombre=nuevoNom;
        }
        else
        Console.WriteLine("No se encuentra el DNI");
    }
    static int menuModificar(){
        int devolver;
        do{
            Console.WriteLine("1- Modificar Apellido");
            Console.WriteLine("2- Modificar Nombre");
            Console.WriteLine("3- Modificar Fecha de Nacimiento");
            Console.WriteLine("4- Modificar Email");
            Console.WriteLine("5- Salir");
            devolver=int.Parse(Console.ReadLine());
        }while(devolver<1||devolver>5);
        return devolver;
    }
    static int IngresarInt(string mensaje){
        int devolver;
        Console.WriteLine(mensaje);
        devolver=int.Parse(Console.ReadLine());
        return devolver;
    }
    static int menuCambios(){
        int devolver;
        do{
            Console.WriteLine("1- Cambiar Velociadad de Piernas");
            Console.WriteLine("2- Cambiar Potencia de Golpes");
            Console.WriteLine("3- Salir");
            devolver=int.Parse(Console.ReadLine());
        }while(devolver<1||devolver>3);
        return devolver;
    }
    static int menuEjercicio(){
        int devolver;
        do{
            Console.WriteLine("1- Cargar Boxeador 1");
            Console.WriteLine("2- Cargar Boxeador 2");
            Console.WriteLine("3- Pelear!");
            Console.WriteLine("4- Salir");
            devolver=int.Parse(Console.ReadLine());
        }while(devolver<1||devolver>4);
        return devolver;
    }
}

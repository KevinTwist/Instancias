using System;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    static void Main(string[] args)
    {
        Instancia[] maquinas = new Instancia[4];
        maquinas[0] = new InstanciaProceso("Proc1", "1.0", "Linux", "BD_Clientes","BD_Precesada");
        maquinas[1] = new InstanciaProceso("Proce2", "2.0", "Windows", "BD_Ventas", "BD_Filtrada");
        maquinas[2] = new InstanciaAplicacion("App1", "1.5", "Linux","java","17","mysql://local/app1");
        maquinas[3] = new InstanciaAplicacion("App2", "3.5", "Ubuntu","Python","3.11", "mongodb://localhost:27017");
        Console.WriteLine("    Levantando instancias.\n");
        foreach (var maquina in maquinas)
        {
            maquina.Levantar();
            Console.WriteLine();
        }
        foreach (var maquina in maquinas)
        {
            maquina.Bajar();
            Console.WriteLine();
        }
    }
}
abstract class Instancia
{
    public string Nombre { get; set; }
    public string Version { get; set; }
    public string SistemaOperativo { get; set; }
    public int Estado { get; set; }
    public Instancia(string nombre, string version, string sistemaOperativo)
    {
        Nombre = nombre;
        Version = version;
        SistemaOperativo = sistemaOperativo;
        Estado = 0;
    }
    public virtual void Levantar()
    {
        Estado = 1;
        Console.WriteLine($"Instancia {Nombre} levantada.");
    }
    public virtual void Bajar()
    {
        Estado = 0;
        Console.WriteLine($"Instancia {Nombre} bajada.");
    }
}
class InstanciaProceso : Instancia
{
    public string DatosOrigen { get; set; }
    public string DatosFin { get; set; }
    public InstanciaProceso(string nombre, string version, string sistemaOperativo, string datosOrigen, string datosFin)
    : base(nombre, version, sistemaOperativo)
    {
        DatosOrigen = datosOrigen;
        DatosFin = datosFin;
    }
    public override void Levantar()
    {
        if (!string.IsNullOrEmpty(DatosOrigen) && !string.IsNullOrEmpty(DatosFin))
        {
            Estado = 1;
            Console.WriteLine($"[Proceso] {Nombre} levantada correctamente.");
            Console.WriteLine($"Acceso correcto a datos de origen: {DatosOrigen}");
            Console.WriteLine($"Acceso correcto a datos de fin: {DatosFin}");
        }
        else
        {
            Console.WriteLine($"[Proceso] {Nombre} no pudo levantarse. Faltan datos.");
        }
    }
}
class InstanciaAplicacion : Instancia
{
    public string Lenguaje { get; set; }
    public string VersionLenguaje { get; set; }
    public string BaseDatos { get; set; }
    public InstanciaAplicacion(string nombre, string version, string sistemaOperativo, string lenguaje, string versionLenguaje, string baseDatos)
    : base(nombre, version, sistemaOperativo)
    {
        Lenguaje = lenguaje;
        VersionLenguaje = versionLenguaje;
        BaseDatos = baseDatos;
    }
    public override void Levantar()
    {
        if (!string.IsNullOrEmpty(Lenguaje) && !string.IsNullOrEmpty(BaseDatos))
        {
            Estado = 1;
            Console.WriteLine($"[Aplicacion] {Nombre} levantada correctamente");
            Console.WriteLine($"Lenguaje {Lenguaje} en version {VersionLenguaje} instalado.");
            Console.WriteLine($"Acceco correctamente a la base de datos: {BaseDatos}");
        }
        else
        {
            Console.WriteLine($"[Aplicación] {Nombre} no pudo levantarse. Falta configuración.");
        }
    }
}
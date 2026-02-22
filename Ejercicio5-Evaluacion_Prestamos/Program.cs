Console.WriteLine("Ingrese el tipo de solicitante (Número): ");
Console.WriteLine("");
Console.WriteLine("1. Empleado fijo");
Console.WriteLine("2. Temporal");
Console.WriteLine("3. Independiente");
Console.WriteLine("4. Estudiante");
Console.WriteLine("");
int tipoSolicitante = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el salario mensual (Q):");
Console.WriteLine("");
double salarioMensual = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la antigüedad laboral (meses): ");
Console.WriteLine("");
int antiguedadLaboral = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el monto solicitado: ");
Console.WriteLine("");
double montoSolicitado = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el historial crediticio (Número): ");
Console.WriteLine("1. Excelencte");
Console.WriteLine("2. Bueno");
Console.WriteLine("3. Regular");
Console.WriteLine("4. Malo");
Console.WriteLine("");
int historialCrediticio = int.Parse(Console.ReadLine());
Console.WriteLine("");
bool tieneFiador= false;
if (tipoSolicitante==1 || historialCrediticio==4)
{
    tieneFiador = true;
}

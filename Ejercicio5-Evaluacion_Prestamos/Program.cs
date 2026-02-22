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

if (salarioMensual>=0 && antiguedadLaboral>=0 && montoSolicitado>=0 && historialCrediticio>=1 && historialCrediticio<=4)
{
    switch(tipoSolicitante)
    {
        case 1:
            if (historialCrediticio==1)
            {
                if (salarioMensual>=1000 && antiguedadLaboral>=6)
                {
                    Console.WriteLine("Situación: Aprobado");
                    Console.WriteLine("Motivo principal: Condiciones cumplidas");
                }
                else if (salarioMensual>=1500 || antiguedadLaboral>=8)
                {
                    Console.WriteLine("Situación: Aprobado con condición");
                    Console.WriteLine("Motivo principal: Se cumplió al menos una condición.");
                }
                else
                {
                    Console.WriteLine("Situación: Rechazado");
                    Console.WriteLine("Motivo principal: No se cumplió ninguna de las condiciones.");
                }
            }
            else if (historialCrediticio == 2)
            {
                if (salarioMensual >= 2000 && antiguedadLaboral >= 10)
                {
                    Console.WriteLine("Situación: Aprobado");
                    Console.WriteLine("Motivo principal: Condiciones cumplidas");
                }
                else if (salarioMensual >= 2500 || antiguedadLaboral >= 12)
                {
                    Console.WriteLine("Situación: Aprobado con condición");
                    Console.WriteLine("Motivo principal: Se cumplió al menos una condición.");
                }
                else
                {
                    Console.WriteLine("Situación: Rechazado");
                    Console.WriteLine("Motivo principal: No se cumplió ninguna de las condiciones.");
                }
            }
            else if (historialCrediticio == 3)
            {
                if (salarioMensual >= 4000 && antiguedadLaboral >= 16)
                {
                    Console.WriteLine("Situación: Aprobado");
                    Console.WriteLine("Motivo principal: Condiciones cumplidas");
                }
                else if (salarioMensual >= 4500 || antiguedadLaboral >= 18)
                {
                    Console.WriteLine("Situación: Aprobado con condición");
                    Console.WriteLine("Motivo principal: Se cumplió al menos una condición.");
                }
                else
                {
                    Console.WriteLine("Situación: Rechazado");
                    Console.WriteLine("Motivo principal: No se cumplió ninguna de las condiciones.");
                }
            }
            else if (historialCrediticio == 4)
            {
                if (tieneFiador && montoSolicitado<1000)
                {
                    Console.WriteLine("Situación: Aprobado con condición");
                    Console.WriteLine("Motivo principal: Cumple con lo mínimo.");
                }
                else
                {
                    Console.WriteLine("Situación: Rechazado");
                    Console.WriteLine("Motivo principal: No cumple con lo mínimo.");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;

        case 2:
            
            break;

        case 3:
            
            break;

        case 4:
            
            break;

        default:
            break;
    }
}
else
{
    Console.WriteLine("Datos inválidos. Por favor ingresar datos válidos.");
}
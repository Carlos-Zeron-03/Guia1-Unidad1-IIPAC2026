namespace Guia1_Unidad1.Bloque_3
{
    public class ValidaciónContraseña
    {
        public ValidaciónContraseña()
        {
            string contraseña;
            bool valida = false;
            while (!valida)
            {
                Console.Write("Ingrese una contraseña: ");
                contraseña = Console.ReadLine();
                if (string.IsNullOrEmpty(contraseña))
                {
                    Console.WriteLine("La contraseña no puede estar vacía.\n");
                    continue;
                }
                bool tieneLongitud = contraseña.Length >= 8;
                bool tieneMayúscula = false;
                bool tieneMinúscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;
                foreach (char c in contraseña)
                {
                    if (char.IsUpper(c))
                    {
                        tieneMayúscula = true;
                    }
                    else
                    {
                        if (char.IsLower(c))
                        {
                            tieneMinúscula = true;
                        }
                        else
                        {
                            if (char.IsDigit(c))
                            {
                                tieneNumero = true;        
                            }
                            else
                            {
                                tieneEspecial = true;
                            } 
                        }
                    }
                }
                if (tieneLongitud && tieneMayúscula && tieneMinúscula && tieneNumero && tieneEspecial)
                {
                    valida = true;
                }
                else
                {
                    Console.WriteLine("La contraseña no cumple con los siguientes requisitos:");
                    if (!tieneLongitud)
                    {
                        Console.WriteLine("- Mínimo 8 caracteres");
                    }
                    if (!tieneMayúscula)
                    {
                       Console.WriteLine("- Al menos una letra mayúscula");                  
                    }
                    if (!tieneMinúscula)
                    {
                        Console.WriteLine("- Al menos una letra minúscula"); 
                    }
                    if (!tieneNumero)
                    {
                        Console.WriteLine("- Al menos un número");
                    }
                    if (!tieneEspecial)
                    {
                        Console.WriteLine("- Al menos un carácter especial");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nContraseña válida, felicidades.");
        }
    }
}
using System;

namespace AppNroRacional
{
    internal class CNroRacional
    {
        // Atributos
        private int aNum;      // Numerador
        private int aDenom;    // Denominador

        // Constructor por defecto
        public CNroRacional()
        {
            aNum = 0;
            aDenom = 1;
        }

        // Constructor que recibe numerador y denominador
        public CNroRacional(int pNum, int pDenom)
        {
            int Divisor = MCD(pNum, pDenom);
            aNum = pNum / Divisor;
            aDenom = pDenom / Divisor;
            normalizar();
        }

        // Método para ingresar fracciones desde la consola
        public void ingresarFraccion()
        {
            Console.Write("Ingrese el numerador: ");
            aNum = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el denominador: ");
            aDenom = int.Parse(Console.ReadLine());

            if (aDenom == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            simplificar();  // Simplifica después de ingresar la fracción
        }

        // Método para mostrar el número racional
        public void mostrarNroRacional()
        {
            Console.WriteLine($"{aNum}/{aDenom}");
        }

        // Método para simplificar la fracción
        private void simplificar()
        {
            int Divisor = MCD(aNum, aDenom);
            aNum /= Divisor;
            aDenom /= Divisor;
            normalizar();
        }

        // Método para calcular el Máximo Común Divisor (MCD)
        private int MCD(int A, int B)
        {
            int Resto = A % B;
            while (Resto != 0)
            {
                A = B;
                B = Resto;
                Resto = A % B;
            }
            return B;
        }

        // Método para normalizar la fracción (denominador positivo)
        private void normalizar()
        {
            if (aDenom < 0)
            {
                aDenom = -aDenom;
                aNum = -aNum;
            }
        }

        // Operación de suma
        public CNroRacional sumar(CNroRacional otra)
        {
            int num = (this.aNum * otra.aDenom) + (otra.aNum * this.aDenom);
            int denom = this.aDenom * otra.aDenom;
            return new CNroRacional(num, denom);
        }

        // Operación de resta
        public CNroRacional restar(CNroRacional otra)
        {
            int num = (this.aNum * otra.aDenom) - (otra.aNum * this.aDenom);
            int denom = this.aDenom * otra.aDenom;
            return new CNroRacional(num, denom);
        }

        // Operación de multiplicación
        public CNroRacional multiplicar(CNroRacional otra)
        {
            int num = this.aNum * otra.aNum;
            int denom = this.aDenom * otra.aDenom;
            return new CNroRacional(num, denom);
        }

        // Operación de división
        public CNroRacional dividir(CNroRacional otra)
        {
            if (otra.aNum == 0)
            {
                throw new ArgumentException("No se puede dividir por una fracción con numerador 0.");
            }
            int num = this.aNum * otra.aDenom;
            int denom = this.aDenom * otra.aNum;
            return new CNroRacional(num, denom);
        }
    }
}

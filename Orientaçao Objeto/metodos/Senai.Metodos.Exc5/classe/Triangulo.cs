namespace Senai.Metodos.Exc5.classe
{
    public class Triangulo
    {  
        // atributo
        public float ladoA, ladoB, ladoC;

        public bool Valido() {
            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public string Tipo() {
            if (ladoA == ladoB && ladoA == ladoC)
            {
                return "equilatero";
            } else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                return "isóceles";
            }else return "escaleno";
        }

    }
}
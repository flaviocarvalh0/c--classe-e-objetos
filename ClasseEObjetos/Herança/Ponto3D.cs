
using Pontos;
namespace Pontos3D
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x,y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //faz alguma coisa
        }

        public override void CalcularDistancia3()
        {
            //faz alguma coisa
        }
    }
}
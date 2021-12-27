using System;
namespace Pontos
{


    public class Ponto
    {
        public int x, y;

        private int distancia;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        Ponto p1 = new Ponto(0, 0);
        Ponto p2 = new Ponto(10, 20);

        protected void CarcularDistancia()
        {
            //faz alguam coisa...
        }
        private void CarcularDistancia2()
        {
            //faz alguam coisa...
        }
        public virtual void CarcularDistancia3()
        {
            //faz alguam coisa...
        }
    }
}
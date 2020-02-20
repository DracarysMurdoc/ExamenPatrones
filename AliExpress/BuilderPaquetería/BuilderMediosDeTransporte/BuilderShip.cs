using BuilderPaquetería.Interfaces;
using BuilderPaquetería.MediosDeTransporte;

namespace BuilderPaquetería.BuilderMediosDeTransporte
{
    public class BuilderShip : IBuilderTransport
    {
        private Ship barco;

        public void Reset()
        {
            barco = new Ship();
        }

        public void CostoKilometro(float costoKilometro)
        {
            barco.CostoKilometro = costoKilometro;
        }

        public void VelocidadEntrega(int velocidadEntrega)
        {
            barco.VelocidadEntrega = velocidadEntrega;
        }

        public Ship GetResult()
        {
            return barco;
        }
    }
}

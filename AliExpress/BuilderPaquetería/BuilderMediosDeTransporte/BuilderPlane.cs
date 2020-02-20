using BuilderPaquetería.Interfaces;
using BuilderPaquetería.MediosDeTransporte;

namespace BuilderPaquetería.BuilderMediosDeTransporte
{
    public class BuilderPlane : IBuilderTransport
    {
        private Plane plane;

        public void Reset()
        {
            plane = new Plane();
        }

        public void CostoKilometro(float costoKilometro)
        {
            plane.CostoKilometro = costoKilometro;
        }

        public void VelocidadEntrega(int velocidadEntrega)
        {
            plane.VelocidadEntrega = velocidadEntrega;
        }

        public Plane GetResult()
        {
            return plane;
        }
    }
}

using BuilderPaquetería.Interfaces;
using BuilderPaquetería.MediosDeTransporte;

namespace BuilderPaquetería.BuilderMediosDeTransporte
{
    public class BuilderTrain : IBuilderTransport
    {
        private Train train;

        public void Reset()
        {
            train = new Train();
        }

        public void CostoKilometro(float costoKilometro)
        {
            train.CostoKilometro = costoKilometro;
        }

        public void VelocidadEntrega(int velocidadEntrega)
        {
            train.VelocidadEntrega = velocidadEntrega;
        }

        public Train GetResult()
        {
            return train;
        }
    }
}

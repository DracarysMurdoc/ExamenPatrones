using BuilderPaquetería.Interfaces;

namespace BuilderPaquetería
{
    public class TransportDirector
    {
        private IBuilderTransport _builder;

        public void SetDirector (IBuilderTransport builder)
        {
            _builder = builder;
        }

        public void ConstructorPlane(IBuilderTransport _builder)
        {
            _builder.CostoKilometro(10);
            _builder.VelocidadEntrega(600);
        }

        public void ConstructorShip(IBuilderTransport _builder)
        {
            _builder.CostoKilometro(1);
            _builder.VelocidadEntrega(46);
        }

        public void ConstructorTrain(IBuilderTransport _builder)
        {
            _builder.CostoKilometro(5);
            _builder.VelocidadEntrega(80);
        }
    }
}

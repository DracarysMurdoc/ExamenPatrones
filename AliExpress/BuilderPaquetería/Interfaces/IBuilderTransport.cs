using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPaquetería.Interfaces
{
    public interface IBuilderTransport
    {
        void CostoKilometro(float costo);

        void VelocidadEntrega(int valocidad);
    }
}

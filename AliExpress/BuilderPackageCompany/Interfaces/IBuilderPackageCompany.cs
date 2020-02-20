using BuilderPaquetería;
using System.Collections.Generic;

namespace BuilderPackageCompany.Interfaces
{
    public interface IBuilderPackageCompany
    {
        void MediosDeTransporte(List<object> medios);

        void MargenDeUtilidad(int porcentaje);
    }
}

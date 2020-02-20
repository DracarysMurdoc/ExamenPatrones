using BuilderPackageCompany.Company;
using BuilderPackageCompany.Interfaces;
using BuilderPaquetería;
using System.Collections.Generic;

namespace BuilderPackageCompany.BuilderPackageCompanies
{
    public class BuilderEstafeta : IBuilderPackageCompany
    {
        private Estafeta _estafeta;

        public void Reset()
        {
            _estafeta = new Estafeta();
        }

        public void MediosDeTransporte(List<object> mediosDeTransporte)
        {
            _estafeta.MediosDeTransporte = mediosDeTransporte;
        }

        public void MargenDeUtilidad(int margenDeUtilidad)
        {
            _estafeta.MargenDeUtilidad = margenDeUtilidad;
        }

        public Estafeta GetResult()
        {
            return _estafeta;
        }
    }
}

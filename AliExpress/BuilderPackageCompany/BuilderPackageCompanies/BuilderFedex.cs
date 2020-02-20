using BuilderPackageCompany.Company;
using BuilderPackageCompany.Interfaces;
using BuilderPaquetería;
using System.Collections.Generic;

namespace BuilderPackageCompany.BuilderPackageCompanies
{
    public class BuilderFedex : IBuilderPackageCompany
    {
        private Fedex _fedex;

        public void Reset()
        {
            _fedex = new Fedex();
        }

        public void MediosDeTransporte(List<object> mediosDeTransporte)
        {
            _fedex.MediosDeTransporte = mediosDeTransporte;
        }

        public void MargenDeUtilidad(int margenDeUtilidad)
        {
            _fedex.MargenDeUtilidad = margenDeUtilidad;
        }

        public Fedex GetResult()
        {
            return _fedex;
        }
    }
}

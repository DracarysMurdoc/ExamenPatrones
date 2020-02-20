using BuilderPackageCompany.Company;
using BuilderPackageCompany.Interfaces;
using BuilderPaquetería;
using System.Collections.Generic;

namespace BuilderPackageCompany.BuilderPackageCompanies
{
    public class BuilderDHL : IBuilderPackageCompany
    {
        private DHL _dhl;

        public void Reset()
        {
            _dhl = new DHL();
        }

        public void MediosDeTransporte(List<object> mediosDeTransporte)
        {
            _dhl.MediosDeTransporte = mediosDeTransporte;
        }

        public void MargenDeUtilidad(int margenDeUtilidad)
        {
            _dhl.MargenDeUtilidad = margenDeUtilidad;
        }

        public DHL GetResult()
        {
            return _dhl;
        }
    }
}

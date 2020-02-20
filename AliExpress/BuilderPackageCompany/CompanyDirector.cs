using BuilderPackageCompany.Interfaces;
using BuilderPaquetería;
using System.Collections.Generic;

namespace BuilderPackageCompany
{
    public class CompanyDirector
    {
        private IBuilderPackageCompany _builderCompany;
        

        public void SetDirector(IBuilderPackageCompany builerCompany)
        {
            _builderCompany = builerCompany;
        }
        public void ConstructorEstafeta(IBuilderPackageCompany _builderCompany)
        {            
            List<object> transportes = new List<object>();
            transportes.Add(Transport.Tren());
            transportes.Add(Transport.Barco());

            _builderCompany.MediosDeTransporte(transportes);
            _builderCompany.MargenDeUtilidad(20);
        }

        public void ConstructorDHL(IBuilderPackageCompany _builderCompany)
        {
            List<object> transportes = new List<object>();
            transportes.Add(Transport.Avion());
            transportes.Add(Transport.Barco());

            _builderCompany.MediosDeTransporte(transportes);
            _builderCompany.MargenDeUtilidad(40);
        }

        public void ConstructorFedex(IBuilderPackageCompany _builderCompany)
        {
            List<object> transportes = new List<object>();
            transportes.Add(Transport.Barco());

            _builderCompany.MediosDeTransporte(transportes);
            _builderCompany.MargenDeUtilidad(50);
        }
    }
}

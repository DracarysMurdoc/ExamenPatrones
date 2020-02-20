using System;
using System.Collections.Generic;
using ControlPaquetes.Interfaces;
using Infraestructure;

namespace ControlPaquetes
{
    public class GestorPaquete
    {
        private ILectorPaquetes _lectorPaquetes;
        public GestorPaquete(ILectorPaquetes lectorPaquetes)
        {
            _lectorPaquetes = lectorPaquetes ?? throw new ArgumentNullException(nameof(lectorPaquetes));
        }

        public string[] RecuperarPaquetes()
        {
            string dataSet = "Paquetes.csv";

            return _lectorPaquetes.LeerListaPaquetes(dataSet);            
        }

        public List<PaqueteDTO> ObtenerDTO()
        {
            string[] paquetes = RecuperarPaquetes();
            string[] lstPaquetes;
            PaqueteDTO paqueteDTO = new PaqueteDTO();
            List<PaqueteDTO> lstPaqueteDTO = new List<PaqueteDTO>();

            foreach(string paquete in paquetes)
            {
                lstPaquetes = paquete.Split(',');

                paqueteDTO.Origen = lstPaquetes[0].ToString();
                paqueteDTO.Destino = lstPaquetes[1].ToString();
                paqueteDTO.Distancia = lstPaquetes[2].ToString();
                paqueteDTO.Paqueteria = lstPaquetes[3].ToString();
                paqueteDTO.MedioDeTransporte = lstPaquetes[4].ToString();
                paqueteDTO.FechaYHoraDePedido = lstPaquetes[5].ToString();

                lstPaqueteDTO.Add(paqueteDTO);
            }

            return lstPaqueteDTO;
        }


    }
}

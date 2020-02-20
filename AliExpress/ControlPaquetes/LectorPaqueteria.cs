using ControlPaquetes.Interfaces;
using System.IO;

namespace ControlPaquetes
{
    public class LectorPaqueteria : ILectorPaquetes
    {
        public string[] LeerListaPaquetes(string url)
        {
            string[] paquetes = File.ReadAllLines(url);

            return paquetes;
        }
    }
}

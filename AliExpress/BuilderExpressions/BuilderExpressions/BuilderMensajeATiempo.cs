using BuilderExpressions.Expressions;
using BuilderExpressions.Interfaces;

namespace BuilderExpressions.BuilderExpressions
{
    public class BuilderMensajeATiempo : IBuilderExpression
    {
        private MensajeATiempo _mensaje;

        public void Reset()
        {
            _mensaje = new MensajeATiempo();
        }

        public void TypeExpression(string typeExpression)
        {
            _mensaje.TypeExpression = typeExpression;
        }

        public void TimeOut(string timeOut)
        {
            _mensaje.TimeOut = timeOut;
        }

        public void ArrivalTime(string arrivalTime)
        {
            _mensaje.ArrivalTime = arrivalTime;
        }

        public void HasTime(string hasTime)
        {
            _mensaje.HasTime = hasTime;
        }

        public void Origin(string origin)
        {
            _mensaje.Origin = origin;
        }

        public void Destiny(string destiny)
        {
            _mensaje.Destiny = destiny;
        }

        public void Date(string date)
        {
            _mensaje.Date = date;
        }

        public void Cost(string cost)
        {
            _mensaje.Cost = cost;
        }

        public void Company(string company)
        {
            _mensaje.Company = company;
        }

        public string GetResult()
        {
            string mensaje = $"Tu paquete {_mensaje.ArrivalTime} de {_mensaje.Origin} y {_mensaje.TimeOut} a {_mensaje.Destiny} el " +
                $"{_mensaje.Date} y {_mensaje.HasTime} un costo de {_mensaje.Cost} \n" +
                $"Cualquier reclamación con {_mensaje.Company}";

            return mensaje;
        }

    }
}

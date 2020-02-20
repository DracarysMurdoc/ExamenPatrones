using BuilderExpressions.Interfaces;
using System;

namespace BuilderExpressions
{
    public class ExpressionsDirector
    {
        private IBuilderExpression _builder;

        public void SerDirector(IBuilderExpression builder)
        {
            _builder = builder;
        }

        public void ConstructorMensajeATiempo(IBuilderExpression _builder)
        {
            _builder.ArrivalTime("");
            _builder.HasTime("");
            _builder.TimeOut("");
            _builder.Origin("");
            _builder.Destiny("");
            _builder.Cost("");
            _builder.Date("");
            _builder.Company("");
            _builder.TypeExpression("");
        }

        public void ConstructorMensajeFueraDeTiempo(IBuilderExpression _builder)
        {
            _builder.ArrivalTime("");
            _builder.HasTime("");
            _builder.TimeOut("");
            _builder.Origin("");
            _builder.Destiny("");
            _builder.Cost("");
            _builder.Date("");
            _builder.Company("");
            _builder.TypeExpression("");
        }

        public void ConstructorPaqueteEntregado(IBuilderExpression _builder)
        {
            _builder.ArrivalTime("");
            _builder.HasTime("");
            _builder.TimeOut("");
            _builder.Origin("");
            _builder.Destiny("");
            _builder.Cost("");
            _builder.Date("");
            _builder.Company("");
            _builder.TypeExpression("");
        }
    }
}

namespace BuilderExpressions.Interfaces
{
    public interface IBuilderExpression
    {
        void TypeExpression(string color);

        void TimeOut(string timeOut);

        void ArrivalTime(string arrivalTime);

        void HasTime(string hasTime);

        void Origin(string origin);

        void Destiny(string destiny);

        void Date(string date);

        void Cost(string cost);

        void Company(string company);
    }
}

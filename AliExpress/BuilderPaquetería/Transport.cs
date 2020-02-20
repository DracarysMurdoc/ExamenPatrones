using BuilderPaquetería.BuilderMediosDeTransporte;
using BuilderPaquetería.MediosDeTransporte;

namespace BuilderPaquetería
{
    public class Transport
    {
        static TransportDirector director = new TransportDirector();        
        
        public static Ship Barco()
        {
            BuilderShip ship = new BuilderShip();
            director.ConstructorShip(ship);

            return ship.GetResult();
        }

        public static Plane Avion()
        {
            BuilderPlane plane = new BuilderPlane();
            director.ConstructorPlane(plane);

            return plane.GetResult();
        }

        public static Train Tren()
        {
            BuilderTrain train = new BuilderTrain();
            director.ConstructorTrain(train);

            return train.GetResult();
        }
        
        
    }
}

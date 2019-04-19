namespace garysCarSale
{
    public interface IStations<T>
    {
        int capacity { get; set; }
        void Refuel( T car );
    }
}
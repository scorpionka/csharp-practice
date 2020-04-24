namespace lect14.task2
{
    public interface INeighbor
    {
        public void AddNeighbor(Neighbor neighbor);
        public Neighbor GetNeighbor(int flatNumber);
    }
}
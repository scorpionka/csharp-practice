namespace lect14.task2
{
    public class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumber { get; set; }
        public Neighbor() { }
        public Neighbor(string fullName, int flatNumber, int phoneNumber)
        {
            FullName = fullName;
            FlatNumber = flatNumber;
            PhoneNumber = phoneNumber;
        }
    }
}
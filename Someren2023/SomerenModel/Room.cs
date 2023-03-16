namespace SomerenModel
{
    public class Room
    {
        //room properties
        public int Id { get; set; }         // database id
        public int Number { get; set; }     // RoomNumber, e.g. 206
        public int Capacity { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public bool Type { get; set; }      // student = false, teacher = true

        //Room constructor
        public Room(int id, int number, int capacity, bool type)
        {
            Id = id;    
            Number = number;
            Capacity = capacity;
            Type = type;
        }

        //ToString override possibly not needed yet, but maybe later 
        public override string ToString()
        {
            if (Type)
            {
               return $"{Id}: Number {Number} / capacity ({Capacity}) / teacher room / ";
            }
            else
            {
                return $"{Id}: Number {Number} / capacity {Capacity} / student room /";
            }
        }
    }
}
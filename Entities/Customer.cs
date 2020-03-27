using ValueObjectPoc.OwnedEntities.ValueObjects;

namespace ValueObjectPoc.OwnedEntities
{
    public class Customer
    {
        public int Id { get; set; }
        public Ssn Ssn {get; set; }
    }
}
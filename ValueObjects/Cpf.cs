

using ValueObjectPoc.OwnedEntities.Extensions;

namespace ValueObjectPoc.OwnedEntities.ValueObjects
{

    public class Ssn
    {
        private readonly string _Value;

        public Ssn(string Value)
        {
            _Value = Value.OnlyNumbers();
    	    //TODO: Validate SSN
        }

        public string Value
        {
            get { return _Value; }
        }

        public bool Contains(string value) {
            return _Value.Contains(value);
        }

        public override string ToString()
        {
            return _Value;
        }

        public static implicit operator string(Ssn Ssn)
        {
            return Ssn.Value;
        }

        public static explicit operator Ssn(string value)
        {
            return new Ssn(value);
        }
    }
}
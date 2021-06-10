namespace PrototypePattern.Sample1
{
    public class ConcretePrototype : Prototype
    {
        public string Attr { get; set; }


        public override Prototype Clone()
        {
            return new ConcretePrototype() { Attr = Attr };
        }
    }
}
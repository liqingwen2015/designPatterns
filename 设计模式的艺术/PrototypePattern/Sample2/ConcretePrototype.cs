namespace PrototypePattern.Sample2
{
    public class ConcretePrototype : Prototype
    {
        public string Attr { get; set; }


        public override object Clone()
        {
            var obj = (ConcretePrototype)MemberwiseClone();
            obj.Attr = Attr;
            return obj;
        }
    }
}
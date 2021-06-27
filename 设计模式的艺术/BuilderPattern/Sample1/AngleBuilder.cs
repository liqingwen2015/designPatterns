namespace BuilderPattern.Sample1
{
    /// <summary>
    /// 天使角色建造者：具体建造者
    /// </summary>
    public class AngleBuilder : ActionBuilder
    {
        public override void BuildType() => Actor.Type = "天使";

        public override void BuildSex() => Actor.Sex = "女";

        public override void BuildFace() => Actor.Face = "漂亮";

        public override void BuildConstume() => Actor.Costume = "白裙";

        public override void BuildHairstyle() => Actor.Hairstyle = "披肩长发";
    }
}
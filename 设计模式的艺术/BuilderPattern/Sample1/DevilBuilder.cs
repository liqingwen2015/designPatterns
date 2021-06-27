namespace BuilderPattern.Sample1
{
    /// <summary>
    /// 恶魔角色建造器：具体建造者
    /// </summary>
    public class DevilBuilder : ActionBuilder
    {
        public override void BuildType() => Actor.Type = "恶魔";

        public override void BuildSex() => Actor.Sex = "妖";

        public override void BuildFace() => Actor.Face = "丑陋";

        public override void BuildConstume() => Actor.Costume = "黑衣";

        public override void BuildHairstyle() => Actor.Hairstyle = "光头";
    }
}
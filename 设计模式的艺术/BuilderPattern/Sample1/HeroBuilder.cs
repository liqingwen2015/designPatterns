namespace BuilderPattern.Sample1
{
    /// <summary>
    /// 英雄角色建造器：具体建造者
    /// </summary>
    public class HeroBuilder : ActionBuilder
    {
        public override void BuildType() => Actor.Type = "英雄";

        public override void BuildSex() => Actor.Sex = "男";

        public override void BuildFace() => Actor.Face = "英俊";

        public override void BuildConstume() => Actor.Costume = "盔甲";

        public override void BuildHairstyle() => Actor.Hairstyle = "飘逸";
    }
}
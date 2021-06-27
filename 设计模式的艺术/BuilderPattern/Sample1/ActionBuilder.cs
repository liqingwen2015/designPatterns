namespace BuilderPattern.Sample1
{
    /// <summary>
    /// 角色建造器：抽象建造者
    /// </summary>
    public abstract class ActionBuilder
    {
        protected Actor Actor = new();

        public abstract void BuildType();

        public abstract void BuildSex();

        public abstract void BuildFace();

        public abstract void BuildConstume();

        public abstract void BuildHairstyle();

        /// <summary>
        /// 工厂方法，返回一个完整的游戏角色对象
        /// </summary>
        /// <returns></returns>
        public Actor CreateActor() => Actor;
    }
}
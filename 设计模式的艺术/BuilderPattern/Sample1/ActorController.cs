namespace BuilderPattern.Sample1
{
    /// <summary>
    /// 游戏角色创建控制器：指挥者
    /// </summary>
    public class ActorController
    {
        /// <summary>
        /// 逐步构建复杂产品对象
        /// </summary>
        /// <param name="ab"></param>
        /// <returns></returns>
        public Actor Construct(ActionBuilder ab)
        {
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildConstume();
            ab.BuildHairstyle();
            return ab.CreateActor();
        }

    }
}
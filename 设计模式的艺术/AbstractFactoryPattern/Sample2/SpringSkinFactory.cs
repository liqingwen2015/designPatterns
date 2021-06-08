namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Spring 皮肤工厂：具体工厂
    /// </summary>
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public ITextField CreaTextField()
        {
            return new SpringTextField();
        }

        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }
    }
}
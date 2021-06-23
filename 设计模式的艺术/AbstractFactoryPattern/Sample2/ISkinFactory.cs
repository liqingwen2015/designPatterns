namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// 界面皮肤工厂接口：抽象工厂
    /// </summary>
    public interface ISkinFactory
    {
        IButton CreateButton();

        ITextField CreaTextField();

        IComboBox CreateComboBox();
    }
}
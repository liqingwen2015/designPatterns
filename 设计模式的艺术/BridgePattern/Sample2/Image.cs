namespace BridgePattern.Sample2
{
    /// <summary>
    /// 抽象图像类：抽象类
    /// </summary>
    public abstract class Image
    {
        protected IImageImp Imp;


        public abstract void ParseFile(string fileName);

        public void SetImageImp(IImageImp imp)
        {
            Imp = imp;
        }
    }
}
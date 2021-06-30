namespace BridgePattern.Sample2
{
    /// <summary>
    /// 抽象操作系统实现类：实现类接口
    /// </summary>
    public interface IImageImp
    {
        /// <summary>
        /// 显示像素矩阵
        /// </summary>
        /// <param name="m"></param>
        void DoPaint(Matrix m);
    }
}
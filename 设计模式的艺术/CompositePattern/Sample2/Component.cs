using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample2
{
    public abstract class Component
    {
        /// <summary>
        /// 增加成员
        /// </summary>
        /// <param name="c"></param>
        public abstract void Add(Component c);

        /// <summary>
        /// 删除成员
        /// </summary>
        /// <param name="c"></param>
        public abstract void Remove(Component c);

        /// <summary>
        /// 获取成员
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public abstract Component GetChild(int i);

        /// <summary>
        /// 业务方法
        /// </summary>
        public abstract void Operation();
    }
}

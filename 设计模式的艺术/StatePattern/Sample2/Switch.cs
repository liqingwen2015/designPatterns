using System;

namespace StatePattern.Sample2
{
    /// <summary>
    /// 开关
    /// </summary>
    public class Switch
    {
        /// <summary>
        /// 状态
        /// </summary>
        private static State _state, _onState, _offState;

        /// <summary>
        /// 状态
        /// </summary>
        public State State
        {
            get => _state;
            set => _state = value;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        public Switch(string name)
        {
            Name = name;
            _onState = new OnState();
            _offState = new OffState();
            State = _onState;
        }

        /// <summary>
        /// 打开
        /// </summary>
        public void On()
        {
            Console.Write(Name);
            State.On(this);
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public void Off()
        {
            Console.Write(Name);
            State.Off(this);
        }

        /// <summary>
        /// 获取状态
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static State GetState(string type) => type == "on" ? _onState : _offState;
    }
}
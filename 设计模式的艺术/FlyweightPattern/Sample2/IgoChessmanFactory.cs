using System.Collections.Generic;

namespace FlyweightPattern.Sample2
{
    public class IgoChessmanFactory
    {
        public static IgoChessmanFactory Instance { get; } = new();

        private static readonly Dictionary<string, IgoChessman> Cache = new();

        static IgoChessmanFactory()
        {
            Cache["b"] = new BlackIgoChessman();
            Cache["w"] = new WhiteIgoChessman();
        }

        public IgoChessman GetIgoChessman(string color) => Cache[color];
    }
}
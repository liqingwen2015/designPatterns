using System.Collections.Generic;

namespace FlyweightPattern.Sample1
{
    public class IgoChessmanFactory
    {
        private static readonly IgoChessmanFactory _instance = new IgoChessmanFactory();
        public static IgoChessmanFactory Instance => _instance;

        private static Dictionary<string, IgoChessman> Cache = new();

        static IgoChessmanFactory()
        {
            Cache["b"] = new BlackIgoChessman();
            Cache["w"] = new WhiteIgoChessman();
        }

        public IgoChessman GetIgoChessman(string color) => Cache[color];
    }
}
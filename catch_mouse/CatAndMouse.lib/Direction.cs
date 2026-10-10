using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{

    public class Direction
    {
        private string _name;
        private string _japanName;
        private static Direction[] _directions = new Direction[4];
        static Random random = new Random();

        private Direction(string name, string japanName)
        {
            _japanName = japanName;
            _name = name;
        }
        private static void CreateDirections()
        {
            _directions[0] = new Direction("Nord", "ノルド");
            _directions[1] = new Direction("Süd", "牛乳");
            _directions[2] = new Direction("West", "西");
            _directions[3] = new Direction("Ost", "オスト");
        }

        static Direction()
        {
            CreateDirections();
        }
        public static Direction GetRandomDirection()
        {
            return _directions[random.Next(_directions.Length)];
        }
        public override string ToString()
        {
            return _name + ' ' + _japanName;
        }
    }
}

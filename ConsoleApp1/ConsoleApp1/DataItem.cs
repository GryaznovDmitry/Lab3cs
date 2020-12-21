using System;
using System.Numerics;

namespace GryaznovLab3
{
    public struct DataItem
    {
        public Vector2 Coord { get; set; }
        public Vector2 Value { get; set; }
        public DataItem(Vector2 CRD, Vector2 VL)
        {
            Coord = CRD;
            Value = VL;
        }
        public DataItem(V5DataOnGrid dg, int x, int y)
        {
            Coord = new Vector2(dg.Net.StepX * x, dg.Net.StepY * y);
            Value = dg.Vec[x, y];
        }
        public override string ToString()
        {
            return Coord.ToString() + " " 
                 + Value.ToString() +"\n";
        }
        public string ToString(string format)
        {
            return Coord.ToString(format) + " "
                 + Value.ToString(format) + "\n"
                 + "Vector Size: " + 
                 Math.Sqrt(Value.X * Value.X + 
                           Value.Y * Value.Y).ToString(format) + "\n";
        }
    }
}

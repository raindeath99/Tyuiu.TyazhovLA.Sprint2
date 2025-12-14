using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = true | (c>d);
            result[1] = true & (b<=d);
            result[2] = (a<d) || true;
            result[3] = true && true;
            result[4] = true;
            result[5] = true;
            return result;
        }
    }
}

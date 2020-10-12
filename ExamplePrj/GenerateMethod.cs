

namespace ExamplePrj
{
    public static class GenerateMethod
    {
        public static int Sum(int a, int b)
        {
            return Calculate(a,b,"+");
        }
        private static int Calculate(int a,int b,string oprator)
        {
            if (oprator == "+")
            {
                return a + b;
            }
            return a-b;
        }

        public static int Sub(int a,int b)
        {
            return Calculate(a, b, "-");
        }
    }
}

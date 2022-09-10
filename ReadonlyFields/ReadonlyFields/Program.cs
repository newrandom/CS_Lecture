using System;

namespace ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2, int newMax)        // 생성자 (매개변수) 로 초기화 과정에서는 readonly 값을 변경할 수 있다 .
        {
            min = v1;
            min = v2;
            max = newMax;
            this.min = v1;
            Console.WriteLine($"{min}, {max}");
        }

        //public void ChangeMax(int newMax)       // 하지만 method 에서는 readonly 값을 변경할 수 없다 !
        //{
        //    max = newMax;
        //}
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //Configuration c = new Configuration(100, 10);
            Configuration c = new Configuration(100, 10, 1000);

        }
    }
}
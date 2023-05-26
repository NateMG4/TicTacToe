using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    internal class Test
    {

        public async void AITest()
        {
            int Games_To_Play = 1000;
            TestRunner tester = new TestRunner(Games_To_Play);
            tester.StartTest();

            while (!tester.finished)
            {
                await Task.Delay(100);
            }


            Debug.WriteLine(tester.record);
            if (tester.record != 0)
            {
                Debug.WriteLine("Fail");
            }
            else
            {
                Debug.WriteLine("Succeed");
            }
        }
    }
}

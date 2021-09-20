using System;
using System.Collections.Generic;
using System.Text;

namespace BindingCrashCourse
{
    class UsefulFunctions
    {
        public static List<int> GenerateListOfRandomInts(int intsRandomMinimumNumber, int intsRandomMaximumNumber)
        {
            List<int> randomNumbersList = new List<int>();
            Random randomNumberGenerator = new Random();
            for (int i = 0; i <= randomNumberGenerator.Next(intsRandomMinimumNumber, intsRandomMaximumNumber); i++)
            {
                randomNumbersList.Add(randomNumberGenerator.Next());
            }
            return randomNumbersList;
        }
    }
}

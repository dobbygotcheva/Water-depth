using System;

namespace WaterDepth
{
    class TestOfStateException : ApplicationException
    {
        public TestOfStateException(string exceptionType)
            : base(exceptionType)
        {

        }
    }
}
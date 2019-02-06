using System;

namespace ValueTuple
{
    /// <summary>
    /// A class used to test out some features
    /// of the Sandcastle Help File Generator
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// This is a fake method that doesn't have tuples anywhere
        /// </summary>
        /// <param name="n">An integer</param>
        /// <returns>A string</returns>
        public string NonTupleMethod(int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A method that uses tuples internally but
        /// doesn't have them on the public API
        /// </summary>
        /// <param name="n">An integer</param>
        /// <returns>A string</returns>
        public string InternalTupleMethod(int n)
        {
            var myResult = (n, n * 2);
            var firstValue = myResult.Item1;
            var secondValue = myResult.Item2;
            return firstValue.ToString() + secondValue.ToString();
        }

        /// <summary>
        /// A method that uses tuples on it's public API
        /// </summary>
        /// <param name="n">An integer</param>
        /// <returns>A tuple</returns>
        public (int, int) PublicTupleMethod(int n)
        {
            return (n, n * 2);
        }
    }
}

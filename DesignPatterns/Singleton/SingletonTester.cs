using System;

namespace DesignPatterns.Singleton
{
    public class SingletonTester
    {
        #region Private Methods
        private static readonly SingletonTester _instance = new SingletonTester();
        #endregion Private Methods

        #region Ctor

        private SingletonTester()
        {
        }
        #endregion

        #region Public Methods

        public static SingletonTester Instance
        {
            get { return _instance; }
        }

        public void TestMethod(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
        #endregion 
    }
}

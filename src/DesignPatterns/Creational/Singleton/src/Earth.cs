using System;
using System.Runtime.CompilerServices;

namespace Design.Singleton
{
    public class Earth
    {
        private static Earth _instance;
        private static readonly object _lock = new object();

        private Earth()
        {

        }

        public static Earth GetInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new Earth();
                    }
                }
                _instance = new Earth();
            }

            return _instance;
        }
    }
}

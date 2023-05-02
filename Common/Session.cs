using System;

namespace Common
{
    [Serializable]
    public class Session
    {
        public int SessionNumber { get; set; }
        public int Year { get; set; }

        public string Technology { get; set; }
    }
}

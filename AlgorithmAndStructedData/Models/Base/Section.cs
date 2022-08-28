using System;

namespace AlgorithmAndStructedData.Models.Base
{

    [Serializable]
    internal class Section
    {
        public bool IsVisAlgo { get; set; }
        public bool IsVisStruct { get; set; }
        public bool IsVisPattern { get; set; }
    }
}

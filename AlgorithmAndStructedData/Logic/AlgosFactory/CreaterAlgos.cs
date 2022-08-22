using AlgorithmAndStructedData.Models.Base;
using AlgorithmAndStructedData.Models.Sort;
using System.Collections.Generic;

namespace AlgorithmAndStructedData.Logic.AlgosFactory
{
    internal class CreaterAlgos : ICreateAlgos
    {
        public CreaterAlgos()
        {

        }

        public Algorithm CreateAlgorithm(AlgosEnum type)
        {
            Algorithm algorithm = null;
            switch (type)
            {
                case AlgosEnum.BubbleSort:
                    algorithm = new BubbleSort("test","test",new List<TaskModel>());
                    break;
            }
            return algorithm;
        }
    }
}

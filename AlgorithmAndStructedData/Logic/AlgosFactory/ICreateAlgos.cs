using AlgorithmAndStructedData.Models.Base;

namespace AlgorithmAndStructedData.Logic.AlgosFactory
{
    internal interface ICreateAlgos
    {
        Algorithm CreateAlgorithm(AlgosEnum type);
    }
}

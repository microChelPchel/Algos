using AlgorithmAndStructedData.Logic.AlgosFactory;
using AlgorithmAndStructedData.Models.Base;

namespace AlgorithmAndStructedData.Controllers
{
    internal class AlgorithmController : BaseController
    {
        public AlgorithmController()
        {

        }

        public Algorithm GetAlgorithm(AlgosEnum type)
        {
            return  new CreaterAlgos().CreateAlgorithm(type);
        }




    }
}

using AlgorithmAndStructedData.Logic;
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

        public void SetAlgorithm(object items, string nameAlgorithm)
        { 
            new AlgorithmServies().SetNewAlgorithm(items, nameAlgorithm);
        }

        public Algorithm GetAlgorithmFile(string nameAlgorithm)
        {
            return new AlgorithmServies().GetAlgorithm(nameAlgorithm);
        }

      
    }
}

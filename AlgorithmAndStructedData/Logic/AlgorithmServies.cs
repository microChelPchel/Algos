using AlgorithmAndStructedData.Controllers;
using AlgorithmAndStructedData.Models.Base;

namespace AlgorithmAndStructedData.Logic
{
    internal class AlgorithmServies
    {
        private AlgorithmController _algorithmController;
        public AlgorithmServies()
        {
            _algorithmController = new AlgorithmController();
        }

        public void SetNewAlgorithm(object items, string nameAlgorithm)
        {
            _algorithmController.Save(items, $"~algos/{nameAlgorithm}.dat");
        }

        public Algorithm GetAlgorithm(string nameAlgorithm)
        {
            return _algorithmController.Load<Algorithm>($"{nameAlgorithm}.dat");
        }
    }
}

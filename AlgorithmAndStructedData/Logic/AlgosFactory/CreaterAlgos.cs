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
                    algorithm = new BubbleSort("Сортировка пузырьком","test","test", GetTasksSorted(AlgosEnum.BubbleSort));
                    break;
            }
            return algorithm;
        }



        public List<TaskModel> GetTasksSorted(AlgosEnum type)
        { 
            //сделать выбор switch

            var  result = new List<TaskModel>();
            var task1 = new TaskModel()
            {
                Name = "TEST",
                TextQuestion = $@"test_test_test_test_test_test_test_test_test_test_
test_test_test_test_test_test_test_test_test_test_test_test_test_test_",
                TextQuestionAnswer = new List<string>(),
                Solution = "TEST_TEST"
            };

            result.Add(task1);

            return result;
        }

    }
}

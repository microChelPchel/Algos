using AlgorithmAndStructedData.Controllers;
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
                    string text = $@"
Пузырьковая сортировка — наверно самая простая сортировка, которую я встречал. Обычно она встречается в книгах по программированию и не выходит за ее пределы. Так как она работает намного медленнее, чем другие алгоритмы сортировки. Но благодаря ей появились алгоритмы, которые более эффективнее чем она сама. Из таких сортировок можно отметить шейкерную или как еще ее называют сортировка перемешиванием.
Принцип работы пузырьковой сортировки можно описать в три пункта:
1.Прохождение по всему массиву;
2.Сравнивание между собой пар соседних ячеек;
3.Если при сравнении оказывается, что значение ячейки i больше, чем значение ячейки i + 1, то мы меняем значения этих ячеек местами;
Ниже вы можете увидеть, как работает пузырьковая сортировка в действии.";

                    List<TaskModel> tasks = new List<TaskModel>();
                    var task1 = new TaskModel()
                    {
                        Name = "TEST",
                        TextQuestion = $@"test_test_test_test_test_test_test_test_test_test_
test_test_test_test_test_test_test_test_test_test_test_test_test_test_",
                        TextQuestionAnswer = new List<string>(),
                        Solution = "TEST_TEST"
                    };

                    tasks.Add(task1);



                    algorithm = new BubbleSort("Алгоритмы","Сортировка пузырьком", text, tasks);
                    break;
            }
            return algorithm;
        }

    }
}

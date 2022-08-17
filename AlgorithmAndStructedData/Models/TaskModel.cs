using System.Collections.Generic;

namespace AlgorithmAndStructedData.Models
{
    internal class TaskModel<T>
    {
        private string _textQuestion;
        private List<T> _textQuestionAnswer;
        private string _solution;

        public TaskModel(string textQuestion, List<T> textQuestionAnswer, string solution)
        {
            _textQuestion= textQuestion;
            _textQuestionAnswer= textQuestionAnswer;
            _solution= solution;
        }

        public string TextQuestion
        { 
            get { return _textQuestion; }
            private set { _textQuestion = value; }
        }

        public List<T> TextQuestionAnswer
        { 
            get { return _textQuestionAnswer; }
            private set { _textQuestionAnswer = value; }
        }

        public string Solution
        {
            get { return _solution; }
            private set { _solution = value; }
        }

    }
}

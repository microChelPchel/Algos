using System.Collections.Generic;

namespace AlgorithmAndStructedData.Models.Base
{
    internal class TaskModel
    {
        private string _name;
        private string _textQuestion;
        private List<string> _textQuestionAnswer;
        private string _solution;

        public TaskModel() { }

        public TaskModel(string textQuestion, List<string> textQuestionAnswer, string solution)
        {
            _textQuestion= textQuestion;
            _textQuestionAnswer= textQuestionAnswer;
            _solution= solution;
        }

        public string TextQuestion
        { 
            get { return _textQuestion; }
            set { _textQuestion = value; }
        }

        public List<string> TextQuestionAnswer
        { 
            get { return _textQuestionAnswer; }
            set { _textQuestionAnswer = value; }
        }

        public string Solution
        {
            get { return _solution; }
            set { _solution = value; }
        }

      
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}

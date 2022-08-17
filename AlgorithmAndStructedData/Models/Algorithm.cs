using System.Collections.Generic;

namespace AlgorithmAndStructedData.Models
{
    internal class Algorithm<T>
    {
        private string _text;
        private string _code;
        /// there create animation 
        /// 
        private List<TaskModel<T>> _tasks;

        public Algorithm(string text,string code, List<TaskModel<T>> tasks)
        {
            _text=text;
            _code=code;
            _tasks = tasks;        
        }

        public string Text
        { 
            get { return _text; }
            private set { _text = value; }
        }

        public string Code
        {
            get { return _code; }
            private set { _code = value; }
        }

        public List<TaskModel<T>> Tasks
        { 
            get {return _tasks;}
            private set { _tasks = value; }
        }

    }
}

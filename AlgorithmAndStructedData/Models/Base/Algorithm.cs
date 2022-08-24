using System.Collections.Generic;

namespace AlgorithmAndStructedData.Models.Base
{
    internal abstract class Algorithm
    {
        private string _name;
        private string _text;
        private string _code;
        private List<TaskModel> _tasks;

        public Algorithm(string name, string text,string code, List<TaskModel> tasks)
        {
            _name = name;
            _text = text;
            _code = code;
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

        public List<TaskModel> Tasks
        { 
            get {return _tasks;}
            private set { _tasks = value; }
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public abstract void Realization();
        


    }
}

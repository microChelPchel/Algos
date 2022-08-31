using System.Collections.Generic;
using System;

namespace AlgorithmAndStructedData.Models.Base
{
    [Serializable]
    internal class Algorithm
    {
        private string _name;
        private string _text;
        private List<TaskModel> _tasks;

        public Algorithm(string name, string text)
        {
            _name = name;
            _text = text;
        }


        public Algorithm(string name, string text, List<TaskModel> tasks) : this(name,text)
        {
            _tasks = tasks;        
        }

        public string Text
        { 
            get { return _text; }
            private set { _text = value; }
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

        
    }
}

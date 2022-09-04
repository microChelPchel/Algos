using System.Collections.Generic;
using System;

namespace AlgorithmAndStructedData.Models.Base
{
    [Serializable]
    internal class Algorithm
    {
        private string _parrent; 
        private string _name;
        private string _text;
        private List<TaskModel> _tasks;


        public Algorithm(string parrent,string name, string text)
        {
            _parrent = parrent;
            _name = name;
            _text = text;
        }


        public Algorithm(string parrent, string name, string text, List<TaskModel> tasks)
            : this(parrent,name, text)
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

        public string Parrent
        {
            get { return _parrent; }
            private set { _parrent = value; }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}

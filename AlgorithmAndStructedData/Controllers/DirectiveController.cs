using AlgorithmAndStructedData.Models.Base;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmAndStructedData.Controllers
{
    internal class DirectiveController : BaseController
    {
        public void CheckDir(string patch)
        { 
            base.CreateDir(patch);
        }

        public List<Algorithm> GetListFilesDirectory(string patch,string pattern="*.dat")
        {
            if (!Directory.Exists(patch))
            {
                return default;
            }
            var result = new List<Algorithm>();
            var nameFiles = Directory.GetFiles(patch, pattern);
            foreach (var nameFile in nameFiles)
            {
                var item = Load<Algorithm>(nameFile);
                result.Add(item);
            }
            return result;
        }
    
    }
}

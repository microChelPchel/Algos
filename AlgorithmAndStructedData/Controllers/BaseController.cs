using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using AlgorithmAndStructedData.Logic;

namespace AlgorithmAndStructedData.Controllers
{
    public abstract class BaseController : ISaveController
    {
        public void Save(object items,string fileName)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, items);
            }
        }

        public T Load<T>(string fileName)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(fileName, FileMode.OpenOrCreate))
            { 
                if(stream.Length>0 && formatter.Deserialize(stream) is T items)
                    return (T)items;
                else
                    return default(T);
            }
        }

    }
}

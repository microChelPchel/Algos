using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AlgorithmAndStructedData.Controllers
{
    public abstract class BaseController
    {
        protected void Save(object items,string fileName)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, items);
            }
        }

        protected T Read<T>(string fileName)
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

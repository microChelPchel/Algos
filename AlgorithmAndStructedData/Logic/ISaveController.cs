
namespace AlgorithmAndStructedData.Logic
{
    interface ISaveController
    {
        void Save(object items, string fileName);
        T Load<T>(string fileName);
        void CreateDir(string path);
    }
}

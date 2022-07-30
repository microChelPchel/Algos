namespace AlgosCore.StructData
{
    /// <summary>
    /// current queue impliement deleate first item  right away after DecEqueue
    /// also this queue work only one record
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class Queue<T>
    {
        private T[] _queue;
        private int _index;

        public Queue()
        {
            CreateArray(1);
        }
        public Queue(int count)
        {
            CreateArray(count);
        }

        public void Enqueue(T item)
        {
            if (IsEmpty())
            {
                var queue = _queue;
                CreateArray(_queue.Length+1);
                _queue.CopyTo(queue, 0);
            }
            _queue[_index] = item;
            _index++;
        }

        public T DecEqueue()
        {
            var item = GetFirstItem();
            var queue = _queue;
            CreateArray(_queue.Length-1);
            _queue.CopyTo(_queue, 1);
            _index--;
            return item;
        }

        public T Seek()
        {
            return GetFirstItem();
        }

        public int GetCount()
        { 
            return _queue.Length;
        }

        public bool IsEmpty()
        { 
            return _queue.Length== 0;
        }


        private void CreateArray(int count)
        {
            _queue = new T[count];
            _index = 0;
        }

        private T GetFirstItem()
        {
            if (IsEmpty())
            {
                throw new System.Exception("queue was is empty");
            }
            return _queue[0];
        }

    }
}

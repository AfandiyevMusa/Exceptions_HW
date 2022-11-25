using System;
using System.Xml.Linq;

namespace Domain.Models
{
	public class MyList<T>
	{
        public string? FullName { get; set; }
        public int Age { get; set; }

        private T[]? _arr;

        public MyList()
        {
            _arr = new T[0];
        }

        public void Add(T vary)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = vary;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        //private int? count = 0;

        public void Clear()
        {
            if (_arr.Length > 0)
            {
                //this._arr = null; 
                //this.count = 0;
                Array.Resize(ref _arr, _arr.Length - _arr.Length);
                Console.WriteLine(_arr[_arr.Length]);


            }
        }

        //public void AddRange(T[] vary)
        //{
        //    Array.Resize(ref _arr, _arr.Length + vary.Length);
        //    _arr[_arr.Length - 1];
        //}

        public void Find(T vary)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = vary; 
                Console.WriteLine(_arr[i]);
            }
            
        }

        //public void FindAll(T vary)
        //{

        //}
    }
}


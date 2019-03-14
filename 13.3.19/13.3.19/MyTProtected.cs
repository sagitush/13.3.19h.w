using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3._19
{
    class MyTProtected<T>:IEnumerable<T> where T:IComparable<T>
    {
        List<T> words;
        public string KeyWord { get; set; }

        public MyTProtected(string keyWord)
        {
            this.words = new List<T>();
            KeyWord = keyWord;
        }

        public void Add(T word)
        {
            if (word == null )
            {
                throw new ArgumentNullException("word was empty");
            }
            foreach (T item in words)
            {
                if (word==item)
                {
                    throw new InvalidOperationException("The word is allready in the list");
                }
            }
            words.Add(word);
        }

        public void Remove(T word)
        {
            if (word == null )
            {
                throw new ArgumentNullException("word was empty");
            }
            int sum = 0;
            foreach (T item in words)
            {
                if (item == word)
                {
                    sum++;
                }
            }
            if (sum == 0)
            {
                throw new ArgumentException("the word dont exist in the list");
            }
            else
            {
                words.Remove(word);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > words.Count)
            {
                throw new ArgumentOutOfRangeException("the index not in the range or smaller than zero");
            }
            words.RemoveAt(index);
        }

        public void Clear(string newKeyWord)
        {
            if (newKeyWord == KeyWord)
            {
                words.Clear();
            }
            else
            {
                throw new AccessViolationException("it is not the key word");
            }
        }

        public void Sort(string newKeyWord)
        {
            if (newKeyWord == KeyWord)
            {
                words.Sort();
            }
            else
            {
                throw new AccessViolationException("it is not the key word");
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (T item in words)
            {
                result = result + $"{item}\n";
            }
            return result;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }

   
}

    


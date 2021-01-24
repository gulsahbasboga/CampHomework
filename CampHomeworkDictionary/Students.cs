using System;
namespace CampHomeworkDictionary
{
    public class Students<TKey, TValue>
    {
        TKey[] keyArray;
        TValue[] valueArray;
        TKey[] tempKeyArray;
        TValue[] tempValueArray;

        public Students()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
            }

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }
        }

        public TKey[] Items1
        {
            get { return keyArray; }
        }

        public TValue[] Items2
        {
            get { return valueArray; }
        }

    }
}

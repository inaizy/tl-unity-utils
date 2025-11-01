using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TLUtils
{
    /**/
    public abstract class Stat<T> : ScriptableObject
    {
        public T Value { get => _value; }
        protected T _value;
        public Action ValueChanged;


        public void Set(T toValue)
        {
            if (!Equals(_value, toValue))
            {
                _value = toValue;
                ValueChanged?.Invoke();
            }
        }

        public abstract void Reset();
        public abstract override string ToString();
    }
}

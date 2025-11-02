using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TLUtils
{
    public abstract class Stat<T> : ScriptableObject
    {
        public T Value { get => _value; }
        [SerializeField] protected T _defaultValue;
        [SerializeField] protected T _value;
        public Action ValueChanged;

        protected virtual void OnEnable()
        {
            _value = _defaultValue;
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (!Application.isPlaying)
                _value = _defaultValue;
        }
#endif


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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace TLUtils
{
    [CreateAssetMenu(menuName = "ScriptableObjects / Stat / Int")]
    public class IntStat : Stat<int>
    {

        public void Add(int amt)
        {
            _value += amt;
            ValueChanged?.Invoke();
        }

        public override void Reset()
        {
            _value = _defaultValue;
            ValueChanged?.Invoke();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

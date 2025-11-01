using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace TLUtils
{

    [CreateAssetMenu(menuName = "ScriptableObjects / Stat / Float")]
    public class FloatStat : Stat<float>
    {

        public void Add(float amt)
        {
            _value += amt;
            ValueChanged?.Invoke();
        }

        public override void Reset()
        {
            _value = 0;
            ValueChanged?.Invoke();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

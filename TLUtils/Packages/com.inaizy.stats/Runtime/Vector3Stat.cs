using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace TLUtils
{
    [CreateAssetMenu(menuName = "ScriptableObjects / Stat / Vector3")]
    public class Vector3Stat : Stat<Vector3>
    {

        public override void Reset()
        {
            _value = _defaultValue;
            ValueChanged?.Invoke();
        }

        public override string ToString()
        {
            return Value.ToString("F3");
        }
    }
}

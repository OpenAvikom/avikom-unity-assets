using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Avikom.UnityAssets.Listeners
{
    public class FindGameObjectByName : VariableListener<Variables.StringVariable, string>
    {
        public Events.UnityGameObjectEvent Response;

        public override void OnEventRaised(string value)
        {
            if (value.Length > 0)
            {
                var gObject = GameObject.Find(value);
                if (gObject != null)
                {
                    Response?.Invoke(gObject);
                }
            }
        }
    }
}

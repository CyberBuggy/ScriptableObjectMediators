using UnityEngine;

namespace CyberBuggy.ScriptableObjectMediators
{
    public static class Mediator
    {
        public static T GetComponentFromReference<T>(this GameObjectReference objReference)
        {
            var objValue = objReference.value;
            var component = objValue.GetComponent<T>();

            return component;
        }
    
    }
}

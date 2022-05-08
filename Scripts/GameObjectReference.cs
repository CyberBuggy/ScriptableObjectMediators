using UnityEngine;

namespace CyberBuggy.ScriptableObjectMediators
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "New GameObject Reference", menuName = "References/GameObject")]
    public class GameObjectReference : ScriptableObject
    {
        public GameObject value;
    }
}

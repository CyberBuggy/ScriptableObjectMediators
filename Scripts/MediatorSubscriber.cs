using UnityEngine;

namespace CyberBuggy.ScriptableObjectMediators
{
    public class MediatorSubscriber : MonoBehaviour
    {
        [Header("Scriptable Object Dependencies")]
        [SerializeField] private GameObjectReference _gameObjectReference;

        [Header("Local Dependencies")]
        [SerializeField] private GameObject _initialObjectToSubscribe;

        [Header("Settings")]
        [SerializeField] private bool _subscribeAtAwake = true;

        private void Awake()
        {
            _gameObjectReference.value = null;

            if (_subscribeAtAwake)
                Subscribe(_initialObjectToSubscribe);
        }
        public void Subscribe(GameObject objToSubscribe) => _gameObjectReference.value = objToSubscribe;

    }
}

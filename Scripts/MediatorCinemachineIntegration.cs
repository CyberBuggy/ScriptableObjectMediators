using Cinemachine;
using UnityEngine;

namespace CyberBuggy.ScriptableObjectMediators
{
    public class MediatorCinemachineIntegration : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera _virtualCamera;
        [SerializeField] private GameObjectReference _gameObjectReference;
        [SerializeField] private bool assignMediatorOnStart = true;

        private void Start()
        {
            if(assignMediatorOnStart)
                AssignMediator(_gameObjectReference);
        }

        private void AssignMediator(GameObjectReference transformReference)
        {
            _virtualCamera.Follow =  _gameObjectReference.value.transform;
        }
    }
}

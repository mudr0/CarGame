using UnityEngine;
using JoostenProductions;

namespace Game.InputLogic 
{
    internal class InputKeyBoard : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 0.01f;

        private void Start() =>
            UpdateManager.SubscribeToUpdate(Move);

        private void OnDestroy()=>
            UpdateManager.UnsubscribeFromUpdate(Move);
        
        private void Move()
        {
            float moveValue = _speed * _inputMultiplier * Time.deltaTime;

            if(Input.GetKey(KeyCode.RightArrow))
                OnRightMove(_inputMultiplier);

            if(Input.GetKey(KeyCode.LeftArrow))
                OnLeftMove(_inputMultiplier);
        }

    }
}

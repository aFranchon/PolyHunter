using System;
using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// Abstract class to implement for creating GlobalVariable.
    /// This is a <see cref="ScriptableObject"/> witch allow to changes the variable's value while playing the game and save it
    /// </summary>
    /// <typeparam name="T">Template to fit every possible type of variable</typeparam>
    public abstract class FsGlobalVariableSo<T> : ScriptableObject
    {
        [SerializeField] private T value;
        
        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                OnValueUpdate?.Invoke();
            }
        }
        
        public Action OnValueUpdate;
    }
}
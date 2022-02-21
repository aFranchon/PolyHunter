using System;
using UnityEngine;

namespace Mouse
{
    public class MouseLockCursor : MonoBehaviour
    {
        [SerializeField] private CursorLockMode lockMode;
        [SerializeField] private bool visible;
        
        private void Awake()
        {
            Cursor.visible = visible;
            Cursor.lockState = lockMode;
        }
    }
}

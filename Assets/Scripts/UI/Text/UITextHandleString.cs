using FSLib.FSGlobalVariables;
using TMPro;
using UnityEngine;

namespace UI.Text
{
    public class UITextHandleString : MonoBehaviour
    {
        [SerializeField] private FsGlobalStringSo textString;
        [SerializeField] private TMP_Text text;

        private void Awake()
        {
            textString.OnValueUpdate += OnStringValueChange;
        }

        private void OnStringValueChange()
        {
            text.text = textString.Value;
        }
        
        private void OnDestroy()
        {
            textString.OnValueUpdate -= OnStringValueChange;
        }
    }
}

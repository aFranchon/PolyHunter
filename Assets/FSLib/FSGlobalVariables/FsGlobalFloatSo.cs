using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="float"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FSGlobalFloat", menuName = "FSGlobalVariables/FSGlobalFloat", order = 1)]
    public class FsGlobalFloatSo : FsGlobalVariableSo<float>
    {
    }
}
using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="string"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FSGlobalString", menuName = "FSGlobalVariables/FSGlobalString", order = 1)]
    public class FsGlobalStringSo : FsGlobalVariableSo<string>
    {
    }
}
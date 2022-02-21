using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="bool"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FSGlobalBool", menuName = "FSGlobalVariables/FSGlobalBool", order = 1)]
    public class FsGlobalBoolSo : FsGlobalVariableSo<bool>
    {
    }
}
using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="int"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FSGlobalInt", menuName = "FSGlobalVariables/FSGlobalInt", order = 1)]
    public class FsGlobalIntSo : FsGlobalVariableSo<int>
    {
    }
}
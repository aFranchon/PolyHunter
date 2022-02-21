using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="Vector3"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FsGlobalVector3", menuName = "FSGlobalVariables/FsGlobalVector3", order = 1)]
    public class FsGlobalVector3So : FsGlobalVariableSo<Vector3>
    {
    }
}
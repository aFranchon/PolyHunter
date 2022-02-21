using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="GameObject"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FsGlobalGameObjectSo", menuName = "FSGlobalVariables/FsGlobalGameObjectSo", order = 1)]
    public class FsGlobalGameObjectSo : FsGlobalVariableSo<GameObject>
    {
    }
}
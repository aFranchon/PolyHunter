using System.Collections.Generic;
using UnityEngine;

namespace FSLib.FSGlobalVariables
{
    /// <summary>
    /// <see cref="List{T}"/> of <see cref="GameObject"/> implementation of the <see cref="FsGlobalVariableSo{T}"/>
    /// </summary>
    /// <inheritdoc/>
    [CreateAssetMenu(fileName = "FsGlobalListGameObject", menuName = "FSGlobalVariables/FsGlobalListGameObject", order = 1)]
    public class FsGlobalListGameObjectSo : FsGlobalVariableSo<List<GameObject>>
    {
    }
}
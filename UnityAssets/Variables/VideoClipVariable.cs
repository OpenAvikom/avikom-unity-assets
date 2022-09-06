using UnityEngine;

namespace Avikom.UnityAssets.Variables
{
    [CreateAssetMenu(menuName = "Primitive/Variables/VideoClipVariable")]
    public class VideoClipVariable : VariableBase<UnityEngine.Video.VideoClip>
    {
        public bool Looped { get; set; }
        public bool AutoPlay { get; set; }

    }
}

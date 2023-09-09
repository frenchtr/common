using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace TravisRFrench.Common.Runtime.Dialog
{
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(DialogTextClip))]
    public class DialogTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<DialogTrackMixer>.Create(graph, inputCount);
        }
    }
}

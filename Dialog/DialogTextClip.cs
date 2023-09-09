using UnityEngine;
using UnityEngine.Playables;

namespace TravisRFrench.Common.Runtime.Dialog
{
    public class DialogTextClip : PlayableAsset
    {
        public string Text;
        
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<DialogBehaviour>.Create(graph);
            var DialogBehaviour = playable.GetBehaviour();

            DialogBehaviour.Text = this.Text;

            return playable;
        }
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.Playables;

namespace TravisRFrench.Common.Runtime.Dialog
{
    public class DialogTrackMixer : PlayableBehaviour
    {
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            var textComponent = playerData as TextMeshProUGUI;
            var currentText = string.Empty;
            var currentAlpha = 0f;

            if (!textComponent)
            {
                return;
            }

            var inputCount = playable.GetInputCount();

            for (var i = 0; i < inputCount; i++)
            {
                var inputWeight = playable.GetInputWeight(i);

                if (inputWeight > 0)
                {
                    var inputPlayable = (ScriptPlayable<DialogBehaviour>)playable.GetInput(i);
                    var input = inputPlayable.GetBehaviour();

                    currentText = input.Text;
                    currentAlpha = inputWeight;
                }
            }

            textComponent.text = currentText;
            textComponent.color = new Color()
            {
                r =  textComponent.color.r,
                g = textComponent.color.g,
                b = textComponent.color.b,
                a = currentAlpha,
            };
        }
    }
}

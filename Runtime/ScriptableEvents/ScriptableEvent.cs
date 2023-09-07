using System;
using UnityEngine;
using UnityEngine.Events;

namespace TravisRFrench.Common.Runtime.ScriptableEvents
{
    [CreateAssetMenu(menuName = "Scriptables/Events/Scriptable Event")]
    public class ScriptableEvent : ScriptableObject
    {
        [SerializeField]
        private UnityEvent raised;

        public event Action Raised;

        public void Raise()
        {
            this.raised?.Invoke();
            this.Raised?.Invoke();
        }
    }

    public abstract class ScriptableEvent<TData> : ScriptableObject
    {
        [SerializeField]
        private UnityEvent<TData> raised;

        public event Action<TData> Raised;

        public void Raise(TData data)
        {
            this.raised?.Invoke(data);
            this.Raised?.Invoke(data);
        }
    }
}

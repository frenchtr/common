using UnityEngine;
using UnityEngine.Events;

namespace TravisRFrench.Common.Runtime.ScriptableEvents
{
    public class ScriptableEventListener : MonoBehaviour
    {
        [SerializeField]
        private ScriptableEvent @event;
        [SerializeField]
        private UnityEvent response;

        protected virtual void Awake()
        {
            this.@event.Raised += this.OnEventRaised;
        }
        
        protected virtual void OnDestroy()
        {
            this.@event.Raised -= this.OnEventRaised;
        }

        private void OnEventRaised()
        {
            this.response?.Invoke();
        }
    }

    public abstract class ScriptableEventListener<TData> : MonoBehaviour
    {
        [SerializeField]
        private ScriptableEvent<TData> @event;
        [SerializeField]
        private UnityEvent<TData> response;

        protected virtual void Awake()
        {
            this.@event.Raised += this.OnEventRaised;
        }
        
        protected virtual void OnDestroy()
        {
            this.@event.Raised -= this.OnEventRaised;
        }

        private void OnEventRaised(TData data)
        {
            this.response?.Invoke(data);
        }
    }
}

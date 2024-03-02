using System.Collections.Generic;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.GameServices
{
    public class GameServiceManager : MonoBehaviour
    {
        [SerializeField]
        private List<GameService> services;

        public IEnumerable<IGameService> Services => this.services;

        private void Awake()
        {
            foreach (var service in this.services)
            {
                service.Setup();
            }
        }

        private void Update()
        {
            foreach (var service in this.services)
            {
                service.Tick(Time.deltaTime);
            }
        }

        private void OnDestroy()
        {
            foreach (var service in this.services)
            {
                service.Teardown();
            }
        }
    }
}

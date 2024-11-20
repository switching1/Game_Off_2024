using System;
using UnityEngine;

namespace Timer
{
    public class Timer : DevObject
    {
        public float RemainingSeconds { get; set; }

        public event Action OnTimerEnd;

        public void Tick(float deltaTime)
        {
            if (RemainingSeconds == 0) return;

            RemainingSeconds -= deltaTime;

            CheckForTimerEnd();
        }

        private void Update()
        {
            Tick(Time.deltaTime);
        }

        private void CheckForTimerEnd()
        {
            if (RemainingSeconds > 0f) return;

            RemainingSeconds = 0f;

            OnTimerEnd?.Invoke();
        }
    }
}

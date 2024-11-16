using System;
using UnityEngine;
using UnityEngine.Events;

namespace Timer
{
    public class TimerBehavior : MonoBehaviour
    {
        [SerializeField] private float duration = 1f;
        [SerializeField] private UnityEvent onTimerEnd = null;

        private Timer _timer;

        private void Start()
        {
            _timer = new Timer(duration);

            _timer.OnTimerEnd += HandleTimerEnd;
        }

        private void HandleTimerEnd()
        {
            onTimerEnd.Invoke();

            Destroy(this);
        }

        private void Update()
        {
            _timer.Tick(Time.deltaTime);
        }
    }
}

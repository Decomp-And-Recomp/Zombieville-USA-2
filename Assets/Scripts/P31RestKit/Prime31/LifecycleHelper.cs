using System;
using System.Threading;
using UnityEngine;

namespace Prime31
{
	public class LifecycleHelper : MonoBehaviour
	{
		private Action<bool> m_onApplicationPausedEvent;

		public event Action<bool> onApplicationPausedEvent
		{
			add
			{
				Action<bool> action = this.m_onApplicationPausedEvent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange(ref this.m_onApplicationPausedEvent, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				Action<bool> action = this.m_onApplicationPausedEvent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange(ref this.m_onApplicationPausedEvent, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

        private void OnApplicationPause(bool paused)
        {
            if (this.m_onApplicationPausedEvent != null)
            {
                this.m_onApplicationPausedEvent(paused);
            }
        }
    }
}

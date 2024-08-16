using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW4
{
    public class SimpleTimer
    {
        public event Action OnTimeElapsed;
        public void Start(int seconds)
        {
            Task.Run(() =>
            {
                Thread.Sleep(seconds * 1000);
                OnTimeElapsed?.Invoke();
            });
        }
    }
}

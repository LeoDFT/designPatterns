﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Data
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}

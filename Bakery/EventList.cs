﻿using System;
using System.Collections.Generic;

namespace Bakery
{
    public class EventList<T> : List<T>
    {
        public event EventHandler OnAdd;
        public event EventHandler OnRemove;

        public void Add(T item)
        {
            base.Add(item);
            if (OnAdd != null)
            {
                OnAdd(this, null);
            }
        }

        public void RemoveAt(int index)
        {
            base.RemoveAt(index);
            if (OnRemove != null)
            {
                OnRemove(this, null);
            }
        }

        public void Clear()
        {
            base.Clear();
            if (OnRemove != null)
            {
                OnRemove(this, null);
            }
        }
    }
}

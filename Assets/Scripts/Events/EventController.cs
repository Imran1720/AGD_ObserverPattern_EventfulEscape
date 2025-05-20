using System;
public class EventController
{
    public Action baseEvent;
    public void AddListener(Action listner) => baseEvent += listner;
    public void RemoveListener(Action listner) => baseEvent -= listner;
    public void InvokeEvent() => baseEvent?.Invoke();
}

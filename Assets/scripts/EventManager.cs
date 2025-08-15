using System.Collections.Generic;
using System;
using UnityEngine;

public enum EEvents
{
    PLYR_HP_CHANGE
}


public class EventManager
{
    public static EventManager instance;
    private Dictionary<EEvents, Action<Dictionary<string, object>>> m_Triggers;


    public static EventManager Instance()
    {
        if (instance == null)
        {
            instance = new EventManager();
        }
        return instance;
    }


    public void StartListening(EEvents TriggerringEvent, Action<Dictionary<string, object>> eventToTrigger)
    {
        if (m_Triggers == null)
        {
            m_Triggers = new Dictionary<EEvents, Action<Dictionary<string, object>>>();
        }

        if (m_Triggers.ContainsKey(TriggerringEvent))
        {
            m_Triggers[TriggerringEvent] += eventToTrigger;
        }
        else
        {
            m_Triggers.Add(TriggerringEvent, eventToTrigger);
        }
    }
    public void StopListening(EEvents TrigerringEvent, Action<Dictionary<string, object>> eventToTrigger)
    {
        if (m_Triggers.ContainsKey(TrigerringEvent))
        {
            m_Triggers[TrigerringEvent] -= eventToTrigger;
            if (m_Triggers[TrigerringEvent] == null)
            {
                m_Triggers.Remove(TrigerringEvent);
            }
        }

    }
    public void TriggerEvent(EEvents TriggerringEvent, Dictionary<string, object> eventParams)
    {
        if (m_Triggers.ContainsKey(TriggerringEvent))
        {
            m_Triggers[TriggerringEvent]?.Invoke(eventParams);
        }
    }

}
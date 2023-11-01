namespace Kirillov_KTAction;

static class EventSystem
{
    private static Dictionary<string, Action>? _actions = new();
    
    public static void CreateEvent(string eventName)
    {
        if (_actions.ContainsKey(eventName)) return;
        
        _actions.Add(eventName,new Action(()=>Console.WriteLine($"{eventName} event is invoked")));
    }
    
    public static void RemoveEvent(string eventName)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions.Remove(eventName);
    }
    
    public static void RaiseEvent(string eventName)
    {
        if (!_actions.ContainsKey(eventName) || _actions[eventName] == null) return;
        
        _actions[eventName].Invoke();
    }

    public static void Clear() => _actions.Clear();
    
    public static void Subscribe(string eventName, Action callBack)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions[eventName] += callBack;
    }
    
    public static void UnSubscribe(string eventName, Action callback)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions[eventName] -= callback;
    }
}
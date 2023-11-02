namespace Kirillov_KTAction;

static class EventSystem
{
    private static Dictionary<string, Action<DateTime>>? _actions = new();
    
    public static void CreateEvent(string eventName)
    {
        if (_actions.ContainsKey(eventName)) return;
        
        _actions.Add(eventName,(_)=>Console.WriteLine($"{eventName} event is invoked"));
    }
    
    public static void RemoveEvent(string eventName)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions.Remove(eventName);
    }
    
    public static void RaiseEvent(string eventName)
    {
        if (!_actions.ContainsKey(eventName) || _actions[eventName] == null) return;
        
        _actions[eventName].Invoke(DateTime.Now);
    }

    public static void Clear() => _actions.Clear();
    
    public static void Subscribe(string eventName, Action<DateTime> callBack)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions[eventName] += callBack;
    }
    
    public static void UnSubscribe(string eventName, Action<DateTime> callback)
    {
        if (!_actions.ContainsKey(eventName)) return;

        _actions[eventName] -= callback;
    }
}
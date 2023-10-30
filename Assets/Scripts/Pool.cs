using System.Collections.Generic;
using UnityEngine;
public class Pool
{
    private static Stack<GameObject> _pool;
    public static void Push(GameObject item)
    {
        if (_pool == null) _pool = new Stack<GameObject>();
        _pool.Push(item);
    }
    public static GameObject Pop()
    {
        if (_pool == null || _pool.Count == 0) return null;
        return _pool.Pop();
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyListGameObjectIntEvent : UnityEvent<List<GameObject>, int, float>
{
}

public class TestEventList : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tests;
    [SerializeField] private MyListGameObjectIntEvent _event;

    private void Start()
    {
        _event.Invoke(_tests, _tests.Count, 13f);
    }

    public void EventListener(List<GameObject> list, int test, float test2)
    {
        foreach (var o in list)
        {
            print(o.name);
        }

        print(test);
        print(test2);
    }
}

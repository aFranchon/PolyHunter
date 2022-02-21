using System.Collections.Generic;
using UnityEngine;

public class TestReceive : MonoBehaviour
{
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

using kevincastejon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = kevincastejon.Event;

public class Example : MonoBehaviour
{
    public EventDispatcher ed;
    public bool dispatched = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MyCallback(Event e)
    {
        Debug.Log(e.Name + " event has been dispatched");
    }

    // Update is called once per frame
    void Update()
    {
        if (!dispatched)
        {
            ed.DispatchEvent(new Event("someEventName"));
            dispatched = true;
        }
    }
}

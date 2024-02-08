using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class DragObject : MonoBehaviour
{
    public Rigidbody body;
    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.drag = 0.5f;
        body.angularDrag = 0.5f;
    }
}

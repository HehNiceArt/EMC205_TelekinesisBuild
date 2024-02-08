using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Drag : MonoBehaviour
{
    [SerializeField] private float detectionRange;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform playerPosition;

    private void Update()
    {
        RayDrag();
    }
    void RayDrag()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, detectionRange))
            {
                GameObject localItem;
                localItem = GameObject.FindWithTag("item");

                if (localItem != null)
                {
                    localItem.transform.position = playerPosition.position;
                    Debug.Log("aaa");
                }
                Debug.Log("adada");  
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * detectionRange);
        Gizmos.DrawWireSphere(transform.position, 2f);
    }
}

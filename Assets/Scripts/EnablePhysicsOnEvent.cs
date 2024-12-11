using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePhysicsOnEvent : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        UIBUttonHandler.OnUIStartButtonClicked += StartPhysicsOnButtonClicked;
        rb.isKinematic = true;
    }

    private void StartPhysicsOnButtonClicked()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnDestroy()
    {
        UIBUttonHandler.OnUIStartButtonClicked -= StartPhysicsOnButtonClicked;
    }
}

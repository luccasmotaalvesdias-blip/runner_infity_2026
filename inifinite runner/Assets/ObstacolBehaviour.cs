using System;
using UnityEngine;

public class obstacolBehaviour : MonoBehaviour
{
    [SerializeField] private float movespeed;
    
    private float movex;

    // Update is called once per frame
    void Update()
    {
        movex = -1 * Time.deltaTime * movespeed;

        transform.Translate(movex, 0, 0);
    }
}

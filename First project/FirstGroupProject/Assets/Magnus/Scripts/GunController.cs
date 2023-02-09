using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * 10f, Color.red, 0f, true);
    }

    private void OnShoot(InputValue shoot)
    {
        Debug.Log($"OnShoot: {shoot.Get()}");
    }
}

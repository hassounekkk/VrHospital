using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWallsDetection : MonoBehaviour
{
    public LayerMask wall;
    [SerializeField]
    GameObject Black;

    private void Update()
    {
        Collider[] c = Physics.OverlapSphere(this.transform.position, 0.05f, wall);


        if (c.Length == 0)
        {
            Black.SetActive(false);
        }
        else Black.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            Debug.Log("You shoud go back");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutLineController : MonoBehaviour
{
    public void OutLineOff()
    {
       this.GetComponent<ObjectController>().Activated = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public bool Activated = true;
    private void Start()
    {
        StartCoroutine(OnOff());
    }
    IEnumerator OnOff()
    {
        this.GetComponent<Outline>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Outline>().enabled = false;
        yield return new WaitForSeconds(0.3f);
        if(Activated)
        StartCoroutine(OnOff());
        
    }
}

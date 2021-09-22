using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchTube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "xxx")
        {
            other.transform.parent.gameObject.SetActive(false);
            this.gameObject.transform.parent.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}

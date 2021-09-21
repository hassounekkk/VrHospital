using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 A = this.gameObject.GetComponent<RectTransform>().localScale;
        this.gameObject.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject.GetComponent<RectTransform>(), A, 1);
        
    }
}

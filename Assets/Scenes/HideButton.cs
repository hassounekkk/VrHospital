using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{
    public Button button;
    public Text text;
    ObjectController[] objectController;

    private void Awake()
    {
          objectController = FindObjectsOfType<ObjectController>();
    }
    public void hide()
    {
        button.gameObject.SetActive(false);
        text.gameObject.SetActive(true);

      foreach(ObjectController o in objectController)
        o.gameObject.GetComponent<ObjectController>().enabled = true;

    }

   
}

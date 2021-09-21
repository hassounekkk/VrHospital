using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{
    public Button button;
    public Text text;
   public void hide()
    {
        button.gameObject.SetActive(false);
        text.gameObject.SetActive(true);

    }
}

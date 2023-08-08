using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SuccessFailTxt : MonoBehaviour
{
    public Text successText;
    public void SetText(string name)
    {
        successText.text = name;
        this.gameObject.SetActive(true);
        Invoke("popupSet", 0.5f);
    }

    public void popupSet()
    {
        this.gameObject.SetActive(false);
    }
}
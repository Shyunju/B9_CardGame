using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public Animator anim;
    public void openCard()
    {
        anim.SetBool("isOpen", true);
        transform.Find("front").gameObject.SetActive(true);
        GameObject back = transform.Find("back").gameObject;
        back.SetActive(false);
        back.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1);
        if (GameManager.I.firstCard == null)
        {
            GameManager.I.firstCard = gameObject;
        }
        else
        {
            GameManager.I.secondCard = gameObject;
            GameManager.I.checkMatched();
        }
    }

    public void destroyCard()
    {
        Invoke("destroyCardInvoke", 1.0f);
    }

    void destroyCardInvoke()
    {
        Destroy(gameObject);
    }

    public void closeCard()
    {
        Invoke("closeCardInvoke", 1.0f);
    }

    void closeCardInvoke()
    {
        anim.SetBool("isOpen", false);
        transform.Find("back").gameObject.SetActive(true);
        transform.Find("front").gameObject.SetActive(false);
    }
}

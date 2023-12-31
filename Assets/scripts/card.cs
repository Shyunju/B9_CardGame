using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public AudioClip flip;
    public AudioSource audioSource; 

    public Animator anim;
    float waitTime = 0.0f;
    bool isFlipping = false;
    public void openCard()
    {
        audioSource.PlayOneShot(flip);
        anim.SetBool("isOpen", true);
        Invoke("openCardInvoke", 0.4f);
        if (GameManager.I.firstCard == null)
        {
            GameManager.I.firstCard = gameObject;
            isFlipping = true;
        }
        else
        {
            GameManager.I.secondCard = gameObject;
            GameManager.I.checkMatched();
        }
    }

    void Update()
    {
        if(isFlipping == true)
        {
            waitTime += Time.deltaTime;

            if (waitTime > 5.0f && GameManager.I.secondCard == null)
            {
                closeCardInvoke();
                GameManager.I.firstCard = null;
            }
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
        isFlipping = false;
        waitTime = 0.0f;
        anim.SetBool("isOpen", false);
        transform.Find("back").gameObject.SetActive(true);
        transform.Find("front").gameObject.SetActive(false);
    }

    void openCardInvoke()
    {
        GameObject back = transform.Find("back").gameObject;
        transform.Find("front").gameObject.SetActive(true);
        back.SetActive(false);
        back.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1);
    }
}

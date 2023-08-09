using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public AudioClip match;
    public AudioClip fail; 
    public AudioSource audioSource; 

    public GameObject failsuccessTxt;
    public GameObject endTxt;
    public GameObject firstCard;
    public GameObject secondCard;

    public Text timeTxt;
    public Text tryTxt;
    int count;
    float time = 30.0f;
    public GameObject card;

    void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;

        string[] membersName = { "박희원", "박희원", "고영현", "고영현", "신현주", "신현주", "김준영", "김준영" };
        List<string> imageNames = new List<string>();

        foreach (string name in membersName)
        {
            for (int i = 0; i < 2; i++)
                imageNames.Add(name + i.ToString());
        }

        imageNames = imageNames.OrderBy(itme => Random.Range(-1.0f, 1.0f)).ToList();

        count = 0;
        for (int i = 0; i < 16; i++)
        {
            GameObject newCard = Instantiate(card);
            newCard.transform.parent = GameObject.Find("Cards").transform;

            float x = (i / 4) * 1.4f - 2.1f;
            float y = (i % 4) * 1.4f - 3.0f;
            newCard.transform.position = new Vector3(x, y, 0);

            string membersImageName = imageNames[i];
            newCard.transform.Find("front").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(membersImageName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeTxt.text = time.ToString("N2");
        tryTxt.text = count.ToString();

        if (time < 10)
        {
            timeTxt.color = Color.red;
        }
        if (time <= 0)
        {
            time = 0;
            end();
        }
    }


    public void checkMatched()
    {
        string firstCardImage = firstCard.transform.Find("front").GetComponent<SpriteRenderer>().sprite.name;
        string secondCardImage = secondCard.transform.Find("front").GetComponent<SpriteRenderer>().sprite.name;

        if (firstCardImage == secondCardImage)
        {
            audioSource.PlayOneShot(match); 

            count++;
            firstCard.GetComponent<card>().destroyCard();
            secondCard.GetComponent<card>().destroyCard();
            failsuccessTxt.GetComponent<SuccessFailTxt>().SetText(firstCardImage.Substring(0, 3));

            int cardsLeft = GameObject.Find("Cards").transform.childCount;
            if (cardsLeft == 2)
            {
                end();
            }
        }
        else
        {
            audioSource.PlayOneShot(fail); 
            
            count++;
            firstCard.GetComponent<card>().closeCard();
            secondCard.GetComponent<card>().closeCard();
            failsuccessTxt.GetComponent<SuccessFailTxt>().SetText("실패!!");
            time -= 5f;
        }
        firstCard = null;
        secondCard = null;
    }

    public void end()
    {
        endTxt.SetActive(true);
        Time.timeScale = 0.0f;
    }

}

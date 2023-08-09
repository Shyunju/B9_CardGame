using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class tmiTxt : MonoBehaviour
{
    public Text tmiText;
    public string[] kim = new string[2];
    public string[] park = new string[2];
    public string[] go = new string[2];
    public string[] shin = new string[2];
    public void makeArray()
    {
        kim[0] = "보드게임을 자체제작 중이다";
        kim[1] = "메이플 스토리를 즐겨한다";

        park[0] = "실제 얼굴보다 순하게 나와서 아주 만족하는 사진이다";
        park[1] = "J 100% 로 습관성 계획을 한다";

        go[0] = "힙찔이 이다";
        go[1] = "MBTI는 INTJ이다";

        shin[0] = "해양 생물을 좋아한다";
        shin[1] = "가장 최근 여행지는 말레이시아 이다";


    }
    public void settingTmi(string name, string number)
    {
        int index = Convert.ToInt32(number);
        if (name == "김준영")
        {
            tmiText.text = kim[index];
        }
        else if (name == "박희원")
        {
            tmiText.text = park[index];
        }
        else if (name == "고영현")
        {
            tmiText.text = go[index];
        }
        else if (name == "신현주")
        {
            tmiText.text = shin[index];
        }

        tmiText.gameObject.SetActive(true);
        Invoke("popupSet", 3f);
    }
    public void popupSet()
    {
        tmiText.gameObject.SetActive(false);
    }
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
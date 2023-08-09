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
        kim[0] = "��������� ��ü���� ���̴�";
        kim[1] = "������ ���丮�� ����Ѵ�";

        park[0] = "���� �󱼺��� ���ϰ� ���ͼ� ���� �����ϴ� �����̴�";
        park[1] = "J 100% �� ������ ��ȹ�� �Ѵ�";

        go[0] = "������ �̴�";
        go[1] = "MBTI�� INTJ�̴�";

        shin[0] = "�ؾ� ������ �����Ѵ�";
        shin[1] = "���� �ֱ� �������� �����̽þ� �̴�";


    }
    public void settingTmi(string name, string number)
    {
        int index = Convert.ToInt32(number);
        if (name == "���ؿ�")
        {
            tmiText.text = kim[index];
        }
        else if (name == "�����")
        {
            tmiText.text = park[index];
        }
        else if (name == "����")
        {
            tmiText.text = go[index];
        }
        else if (name == "������")
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
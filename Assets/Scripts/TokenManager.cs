using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TokenManager : MonoBehaviour
{
    public Info I;
    public Interface It;
    public void Start()
    {
        It = GameObject.Find("Main Camera").GetComponent<Interface>();
        I = GameObject.Find("Info").GetComponent<Info>(); 
        Debug.Log(It);
    }
    public void tokens_10()
    {
        I.Token += 10;
    }
    
    public void tokens_25()
    {
        I.Token += 25;
    }

    public void tokens_50()
    {
        I.Token += 50;
    }

    public void tokens_110()
    {
        I.Token += 110;
    }
    public void CornTokens5()
    {
        if(I.Corn>=100)
        {
            I.Corn-=100;
            I.Token+=5;
        }
    }
    public void CornTokens10()
    {
        if(I.Corn>=180)
        {
            I.Corn-=180;
            I.Token+=10;
        }
    }
    public void CornTokens25()
    {
        if(I.Corn>=400)
        {
            I.Corn-=400;
            I.Token+=25;
        }
    }
    public void CornTokens45()
    {
        if(I.Corn>=725)
        {
            I.Corn-=725;
            I.Token+=45;
        }
    }
    public void Back()
    {
        It.TKShop.SetActive(false);
    }
    public void Enter()
    {
        It.TKShop.SetActive(true);
    }
}

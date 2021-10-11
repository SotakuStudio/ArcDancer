using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{

    public GameObject ButtonStartObj;//游戏开始时隐藏开始按钮
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //当按钮按下的时候，游戏开始，隐藏按钮
    public void GameStart()
    {
        GameManagement.ButtonStartBool = true;//游戏开始
        ButtonStartObj.SetActive(false);//隐藏按钮
    }
}

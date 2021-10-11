using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManagement : MonoBehaviour
{
    public enum CharSelectState
    {
        Char1,
        Char2,
        Char3,
        Char4
    }
    public CharSelectState charSelectState;
    //定义4个位置-X方向
    private float Pos1X = -696.0f;
    private float Pos2X = -232.0f;
    private float Pos3X = 232.0f;
    private float Pos4X = 696.0f;

    public GameObject Player1Mark;
    //
    private bool ButtonChangeBool = true; //一开始是可以更改位置的，按下按键之后一定时间内不行
    private float WaitTime = 0.2f;//更改一次状态之后，一定时间之后才能更改状态


    // Start is called before the first frame update
    void Start()
    {
        Player1Mark.transform.localPosition = new Vector3(Pos1X, this.transform.localPosition.y, this.transform.localPosition.z);
    }
    // Update is called once per frame
    void Update()
    {
        //
        float x = Input.GetAxis("Player1AxisX");
        //float y = Input.GetAxis("Player1AxisY");

        //只有在被允许的情况下可以更改状态
        if(ButtonChangeBool == true)
        {
            //根据不同选择状态决定选择目标
            switch (charSelectState)
            {
                case CharSelectState.Char1:
                    if (x > 0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char2;
                    }
                    else if (x < -0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char4;
                    }
                    Player1Mark.transform.localPosition = new Vector3(Pos1X, this.transform.localPosition.y, this.transform.localPosition.z);
                    break;
                case CharSelectState.Char2:
                    if (x > 0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char3;
                    }
                    else if (x < -0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char1;
                    }
                    Player1Mark.transform.localPosition = new Vector3(Pos2X, this.transform.localPosition.y, this.transform.localPosition.z);
                    break;
                case CharSelectState.Char3:
                    if (x > 0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char4;
                    }
                    else if (x < -0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char2;
                    }
                    Player1Mark.transform.localPosition = new Vector3(Pos3X, this.transform.localPosition.y, this.transform.localPosition.z);
                    break;
                case CharSelectState.Char4:
                    if (x > 0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char1;
                    }
                    else if (x < -0.5f)
                    {
                        Invoke("ButtonChangeCan", WaitTime);//
                        ButtonChangeBool = false;
                        charSelectState = CharSelectState.Char3;
                    }
                    Player1Mark.transform.localPosition = new Vector3(Pos4X, this.transform.localPosition.y, this.transform.localPosition.z);
                    break;
                default:
                    //Debug.Log("Invalid Level Selected!");
                    break;
            }
        }
        
    }
    void ButtonChangeCan()
    {
        ButtonChangeBool = true;
    }
}

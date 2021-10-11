using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed; //能够接收到输入按键
    public bool canBeGood; //此区域可以输入Good
    public bool canBePerfect; //此区域可以输入Perfect

    //public KeyCode keyToPress;

    //显示各个图标用 Good Perfect Miss
    public GameObject GoodEffect;
    public GameObject PerfectEffect;
    public GameObject MissEffect;
    //Time
    public float GoodEffectTime = 1.0f;
    public float PerfectEffectTime = 1.0f;
    public float MissEffectTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Player1ButtonA"))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //此时能够点击按钮
        if(other.tag == "Body")
        {
            canBePressed = true;
        }
        //Good
        if (other.tag == "Good")
        {
            canBeGood = true;
        }
        //Perfect
        if (other.tag == "Perfect")
        {
            canBePerfect = true;
        }
        //Miss
        if (other.tag == "Miss")
        {
            //显示Miss图标
            MissEffect.gameObject.SetActive(true);
            //一定时间后使得Miss图标消失
            Invoke("CloseMissEffect", MissEffectTime);//           
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        //超过这个范围则无法点击按钮
        if (other.tag == "Body")
        {
            canBePressed = false;
        }
    }
    void CloseMissEffect()
    {
        MissEffect.gameObject.SetActive(false);
    }
}

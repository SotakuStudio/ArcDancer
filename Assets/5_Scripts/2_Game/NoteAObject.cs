using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAObject : MonoBehaviour
{
    //public bool canBePressed; //能够接收到输入按键
    private bool canBeGood; //此区域可以输入Good
    private bool canBePerfect; //此区域可以输入Perfect

    //public KeyCode keyToPress;

    //显示各个图标用 Good Perfect Miss
    public GameObject GoodEffect;
    public GameObject PerfectEffect;
    public GameObject MissEffect;
    //Time
    public float GoodEffectTime;
    public float PerfectEffectTime;
    public float MissEffectTime;
    //Input结束与否
    private bool InputEndBool = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Player1ButtonA"))
        //{
        //    if(canBePressed)
        //    {
        //        //gameObject.SetActive(false);
        //    }
        //}
        //
        if (Input.GetButtonDown("Player1ButtonA"))
        {
            if (InputEndBool == false)
            {
                if (canBeGood)
                {
                    //显示Good图标
                    GoodEffect.gameObject.SetActive(true);
                    //一定时间后使得Good图标消失
                    Invoke("CloseGoodEffect", GoodEffectTime);// 
                                                              //输入完毕，不显示Miss图标
                    InputEndBool = true;
                }
                if (canBePerfect)
                {
                    //显示Good图标
                    PerfectEffect.gameObject.SetActive(true);
                    //一定时间后使得Perfect图标消失
                    Invoke("ClosePerfectEffect", PerfectEffectTime);// 
                                                                    //输入完毕，不显示Miss图标
                    InputEndBool = true;
                }
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //此时能够点击按钮
        if(other.tag == "Body")
        {
            //canBePressed = true;
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
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        //超过这个范围则无法点击按钮
        if (other.tag == "Body")
        {
            //canBePressed = false;
        }
        //Good
        if (other.tag == "Good")
        {
            canBeGood = false;
        }
        //Perfect
        if (other.tag == "Perfect")
        {
            canBePerfect = false;
        }
        
        //Miss
        if (other.tag == "Miss")
        {
            if(InputEndBool == false)
            {
                // 显示Miss图标
                MissEffect.gameObject.SetActive(true);
                //一定时间后使得Miss图标消失
                Invoke("CloseMissEffect", MissEffectTime);//  
            }
                    
        }
    }
    //关闭MissEffect
    void CloseMissEffect()
    {
        MissEffect.gameObject.SetActive(false);
    }
    //关闭GoodEffect
    void CloseGoodEffect()
    {
        GoodEffect.gameObject.SetActive(false);
    }
    //关闭PerfectEffect
    void ClosePerfectEffect()
    {
        PerfectEffect.gameObject.SetActive(false);
    }
}

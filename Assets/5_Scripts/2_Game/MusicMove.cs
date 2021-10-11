using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMove : MonoBehaviour
{
    public GameObject NoteGroup;//游戏开始时隐藏开始按钮
    public float beatTempo;//音谱自动速度
    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        //当游戏开始的时候，开始移动
        if(GameManagement.ButtonStartBool)
        {
            NoteGroup.transform.Translate(-beatTempo * Time.deltaTime, 0, 0, Space.World);
        }
        else
        {

        }
    }
}

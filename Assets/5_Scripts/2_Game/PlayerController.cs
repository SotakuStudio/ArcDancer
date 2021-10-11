using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer Player1;
    public Sprite player1DefaultImage;
    public Sprite player1PressedImage;
    private SpriteRenderer Player2;
    public Sprite player2DefaultImage;
    public Sprite player2PressedImage;
    private SpriteRenderer Player3;
    public Sprite player3DefaultImage;
    public Sprite player3PressedImage;
    private SpriteRenderer Player4;
    public Sprite player4DefaultImage;
    public Sprite player4PressedImage;



    //public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        Player1 = GetComponent<SpriteRenderer>();
        Player2 = GetComponent<SpriteRenderer>();
        Player3 = GetComponent<SpriteRenderer>();
        Player4 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(keyToPress))
        //{
        //    PlayerA.sprite = pressedImage;
        //}
        //if (Input.GetKeyUp(keyToPress))
        //{
        //    PlayerA.sprite = defaultImage;
        //}

        //äﬂâ∆àÍçÜ
        if (Input.GetButtonDown("Player1ButtonA"))
        {
            Player1.sprite = player1PressedImage;
        }
        if (Input.GetButtonUp("Player1ButtonA"))
        {
            Player1.sprite = player1DefaultImage;
        }
        ////äﬂâ∆ìÒçÜ
        //if (Input.GetButtonDown("Player2ButtonA"))
        //{
        //    Player2.sprite = player2PressedImage;
        //}
        //if (Input.GetButtonUp("Player2ButtonA"))
        //{
        //    Player2.sprite = player2DefaultImage;
        //}
        ////äﬂâ∆3çÜ
        //if (Input.GetButtonDown("Player3ButtonA"))
        //{
        //    Player3.sprite = player3PressedImage;
        //}
        //if (Input.GetButtonUp("Player3ButtonA"))
        //{
        //    Player3.sprite = player3DefaultImage;
        //}
        ////äﬂâ∆4çÜ
        //if (Input.GetButtonDown("Player4ButtonA"))
        //{
        //    Player4.sprite = player4PressedImage;
        //}
        //if (Input.GetButtonUp("Player4ButtonA"))
        //{
        //    Player4.sprite = player4DefaultImage;
        //}

    }
}

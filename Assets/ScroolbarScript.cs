using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScroolbarScript : MonoBehaviour {


    public Image Img1;
    public Image Img2;
    public Image Img3;
    public Image Img4;
    public Image Img5;

    public Button bt1;
    public Button bt2;
    public Button bt3;
    public Button bt4;
    public Button bt5;

    Image NextImg;
    Image CurrentImg;

    public Scrollbar Scb;

    public GameObject UISTAGE;

    int sexnum;

    Vector3 FtPos;

    Vector3 firstClickLocalPos;



    float movedis;
    float standarddis = 10.0f;
    bool isMove;
    float realMoveDis;
    // Use this for initialization
    void Start () {
        CurrentImg = Img3;
	}
	
	// Update is called once per frame
	void Update () {

        /////////// 스크롤인듯

        if(Input.GetMouseButtonDown(0))
        {
            FtPos = Input.mousePosition;
            firstClickLocalPos = UISTAGE.transform.localPosition;
            realMoveDis = 0.0f;
            movedis = 0.0f;
        }

        if (Input.GetMouseButton(0))
        {
            movedis = FtPos.x - Input.mousePosition.x;

            if ((movedis > 0 ? movedis : -movedis) > standarddis)
            {
                if (movedis > 0)
                {
                    realMoveDis = movedis - standarddis;
                }
                else
                {
                    realMoveDis = movedis + standarddis;
                }

                Vector3 moveVec = UISTAGE.transform.localPosition;
                moveVec.x = firstClickLocalPos.x - realMoveDis;
                UISTAGE.transform.localPosition = moveVec;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            float WhatPos = FtPos.x - Input.mousePosition.x;
            
            if(WhatPos>300)
            {
                Debug.Log(1);
            }
            else if(WhatPos<-300)
            {
                Debug.Log(2);
            }
            else
            {
                Debug.Log(3);
            }
        }


        //////////


        if (isMove&&Scb.value>=0.06f&&sexnum==1)
        {
            UISTAGE.transform.position = new Vector3(11.5f, 0.8f, 0);
            Scb.value -= 0.05f;
        }
        else if (isMove && Scb.value >= 0.299f && sexnum == 2)
        {
            UISTAGE.transform.position = new Vector3(6, 0.8f, 0);
            Scb.value -= 0.05f;
        }
        else if (isMove && Scb.value < 0.24f && sexnum == 2)
        {
            UISTAGE.transform.position = new Vector3(6, 0.8f, 0);
            Scb.value += 0.05f;
        }
        else if (isMove && Scb.value <= 0.45f && sexnum == 3)
        {
            UISTAGE.transform.position = new Vector3(0.1f, 0.8f, 0);
            Scb.value += 0.05f;
        }
        else if (isMove && Scb.value > 0.5f && sexnum == 3)
        {
            UISTAGE.transform.position = new Vector3(0.1f, 0.8f, 0);
            Scb.value -= 0.05f;
        }
        else if (isMove && Scb.value <= 0.73f && sexnum == 4)
        {
            UISTAGE.transform.position = new Vector3(-5.4f, 0.8f, 0);
            Scb.value += 0.05f;
        }
        else if (isMove && Scb.value >= 0.79f && sexnum == 4)
        {
            UISTAGE.transform.position = new Vector3(-5.4f, 0.8f, 0);
            Scb.value -= 0.05f;
        }
        else if (isMove && Scb.value <= 0.95f && sexnum == 5)
        {
            UISTAGE.transform.position = new Vector3(-10.8f, 0.8f, 0);
            Scb.value += 0.05f;
        }
        else
        {
            isMove = false;
        }
    }

    
    public void ScroolBtDown(int BtNum)
    {
        if(BtNum==1)
        {
            sexnum = BtNum;
            SetOnAndOff(Img1);
            SetBtPos(BtNum);
            isMove = true;
        }
        else if(BtNum ==2)
        {
            sexnum = BtNum;
            isMove = true;
            SetOnAndOff(Img2);
            SetBtPos(BtNum);
        }
        else if(BtNum==3)
        {
            sexnum = BtNum;
            isMove = true;
            SetOnAndOff(Img3);
            SetBtPos(BtNum);
        }
        else if(BtNum==4)
        {
            sexnum = BtNum;
            isMove = true;
            SetOnAndOff(Img4);
            SetBtPos(BtNum);
        }
        else if(BtNum==5)
        {
            sexnum = BtNum;
            isMove = true;
            SetOnAndOff(Img5);
            SetBtPos(BtNum);
        }
    }

    void SetOnAndOff(Image img)
    {
        CurrentImg.gameObject.SetActive(false);
        CurrentImg = img;
        img.gameObject.SetActive(true);
    }

    void MoveLeft()
    {
            UISTAGE.transform.position = new Vector3(UISTAGE.transform.position.x + 1, 0.8f, 0);
    }

    void MoveRight()
    {

    }


    void SetBtPos(int num)
    {
        if(num==1)
        {
            bt1.gameObject.transform.position = new Vector3(-2.37f, -4.48f, 90);
            bt2.gameObject.transform.position = new Vector3(-0.59f, -4.48f, 90);
            bt3.gameObject.transform.position = new Vector3(0.4f,-4.48f,90);
            bt4.gameObject.transform.position = new Vector3(1.365f, -4.48f, 90);
            bt5.gameObject.transform.position = new Vector3(2.326f, -4.48f, 90);
        }
        else if (num == 2)
        {
            bt1.gameObject.transform.position = new Vector3(-2.37f, -4.48f, 90);
            bt2.gameObject.transform.position = new Vector3(-1.39f, -4.48f, 90);
            bt3.gameObject.transform.position = new Vector3(0.4f, -4.48f, 90);
            bt4.gameObject.transform.position = new Vector3(1.365f, -4.48f, 90);
            bt5.gameObject.transform.position = new Vector3(2.326f, -4.48f, 90);
        }
        else if (num == 3)
        {
            bt1.gameObject.transform.position = new Vector3(-2.37f, -4.48f, 90);
            bt2.gameObject.transform.position = new Vector3(-1.39f, -4.48f, 90);
            bt3.gameObject.transform.position = new Vector3(-0.053f, -4.48f, 90);
            bt4.gameObject.transform.position = new Vector3(1.365f, -4.48f, 90);
            bt5.gameObject.transform.position = new Vector3(2.326f, -4.48f, 90);
        }
        else if (num == 4)
        {
            bt1.gameObject.transform.position = new Vector3(-2.37f, -4.48f, 90);
            bt2.gameObject.transform.position = new Vector3(-1.39f, -4.48f, 90);
            bt3.gameObject.transform.position = new Vector3(-0.41f, -4.48f, 90);
            bt4.gameObject.transform.position = new Vector3(1.365f, -4.48f, 90);
            bt5.gameObject.transform.position = new Vector3(2.326f, -4.48f, 90);
        }
        else if (num == 5)
        {
            bt1.gameObject.transform.position = new Vector3(-2.37f, -4.48f, 90);
            bt2.gameObject.transform.position = new Vector3(-1.39f, -4.48f, 90);
            bt3.gameObject.transform.position = new Vector3(-0.41f, -4.48f, 90);
            bt4.gameObject.transform.position = new Vector3(0.55f, -4.48f, 90);
            bt5.gameObject.transform.position = new Vector3(2.326f, -4.48f, 90);
        }
    }
}

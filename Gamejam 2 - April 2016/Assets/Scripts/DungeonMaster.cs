using UnityEngine;
using System.Collections;

public class DungeonMaster : MonoBehaviour
{
    //public TrapPlaceholder one;
    //public TrapPlaceholder two;
    //public TrapPlaceholder three;
    //public TrapPlaceholder four;
    //public TrapPlaceholder five;

    //Transform cameraMaster;
    //
    //public Transform playerOne;
    //public Transform playerTwo;
    //public Transform playerThree;

    public int score;

    //float pOneX;
    //float pOneY;
    //
    //float pTwoX;
    //float pTwoY;
    //
    //float pThreeX;
    //float pThreeY;

    // Use this for initialization
    void Start()
    {

        //cameraMaster = GetComponentInParent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

//        pOneX = playerOne.position.x;
//        pOneY = playerOne.position.y;
//
//        pTwoX = playerTwo.position.x;
//        pTwoY = playerTwo.position.y;
//
//        pThreeX = playerThree.position.x;
//        pThreeY = playerThree.position.y;
    }


    void AddPoint()
    {
        //placeholder score
        score += 10;
    }


    //void UpdateCamera()
    //{
    //    //find average x value
    //    float xAv = (pOneX + pTwoX + pThreeX) / 3;
    //
    //    //find average y value
    //    float yAv = (pOneY + pTwoY + pThreeY) / 3;
    //
    //    Vector3 newPos = new Vector3(xAv, yAv, cameraMaster.position.z);
    //    cameraMaster.position = newPos;
    //
    //
    //    //change the orthographic size value
    //
    //    //find highest/lowest x value
    //
    //    float hiX = 0;
    //    float hiY = 0;
    //    float loX = 0;
    //    float loY = 0;
    //
    //    if (pOneX > pTwoX && pOneX > pThreeX)
    //        hiX = pOneX;
    //    else if (pTwoX > pOneX && pTwoX > pThreeX)
    //        hiX = pTwoX;
    //    else if (pThreeX > pOneX && pThreeX > pTwoX)
    //        hiX = pThreeX;
    //
    //    if (pOneX < pTwoX && pOneX < pThreeX)
    //        loX = pOneX;
    //    else if (pTwoX < pOneX && pTwoX < pThreeX)
    //        loX = pTwoX;
    //    else if (pThreeX < pOneX && pThreeX < pTwoX)
    //        loX = pThreeX;
    //
    //    //find highest y value
    //
    //    if (pOneY > pTwoY && pOneY > pThreeY)
    //        hiY = pOneY;
    //    else if (pTwoY > pOneY && pTwoY > pThreeY)
    //        hiY = pTwoY;
    //    else if (pThreeY > pOneY && pThreeY > pTwoY)
    //        hiY = pThreeY;
    //
    //    if (pOneY < pTwoY && pOneY < pThreeY)
    //        loY = pOneY;
    //    else if (pTwoY < pOneY && pTwoY < pThreeY)
    //        loY = pTwoY;
    //    else if (pThreeY < pOneY && pThreeY < pTwoY)
    //        loY = pThreeY;
    //
    //    GetComponent<Camera>().orthographicSize = (hiX - loX / hiY - loY) + 5;
    //}
}
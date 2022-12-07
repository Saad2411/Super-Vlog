using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingManager : MonoBehaviour
{
    public GameObject movingPlatform;
    public GameObject movingPlatform1;
    public GameObject movingPlatform2;
    public GameObject movingPlatform3;
    public GameObject movingPlatform4;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(movingPlatform, 4, 2f).setEaseInOutBack().setLoopPingPong();

        LeanTween.moveLocalX(movingPlatform1, -14, 3f).setEaseInBack().setLoopPingPong();
        LeanTween.moveLocalY(movingPlatform1, 5, 3f).setEaseInBack().setLoopPingPong();

        LeanTween.moveLocalY(movingPlatform2, -2, 3f).setEaseInOutSine().setLoopPingPong();

        LeanTween.moveLocalX(movingPlatform3, 0, 5f).setEaseInBack().setLoopPingPong();

        LeanTween.moveLocalX(movingPlatform4, -13, 7f).setEaseInBack().setLoopPingPong();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

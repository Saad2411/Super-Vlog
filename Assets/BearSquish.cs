using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSquish : MonoBehaviour
{
    float _animLength;
    public AnimationClip SquishAnim;
    // Start is called before the first frame update
    void Start()
    {
        _animLength = SquishAnim.length;
    }

    

    public IEnumerator Squash()
    {
        yield return new WaitForSeconds(.5f);

        this.gameObject.GetComponent<Animator>().Play("Squish");

        yield return new WaitForSeconds(_animLength);

        this.gameObject.GetComponent<Animator>().Play("New State");
    }
}

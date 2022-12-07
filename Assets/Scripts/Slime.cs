using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    float _animLength;

    public AnimationClip slimeAnim;
    private void Start()
    {
        _animLength = slimeAnim.length;
    }

    public IEnumerator SlimeHit()
    {
        yield return new WaitForSeconds(.5f);

        this.gameObject.GetComponent<Animator>().Play("Squish");

        yield return new WaitForSeconds(_animLength);

        this.gameObject.GetComponent<Animator>().Play("New State");
    }
}

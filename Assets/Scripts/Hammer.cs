using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    public bool _isHitting = false;

    public GameObject hammer;
    public AnimationClip hammerAnim;

    float _animLength;

    public GameObject hitDetector;
    public float hitRadius = 1.5f;

    public GameObject slime;

    private void Start()
    {
        _animLength = hammerAnim.length;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            if (_isHitting == false)
            {
                StartCoroutine(HammerHit());
                CheckHit();
            }
        }

        
    }

    public void CheckHit()
    {
        Collider[] hitcolliders = Physics.OverlapSphere(hitDetector.transform.position, hitRadius);
        foreach (var hitcollider in hitcolliders)
        {
            if (hitcollider.CompareTag("Slime"))
            {
                StartCoroutine(slime.GetComponent<Slime>().SlimeHit());
            }

        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        //Use the same vars you use to draw your Overlap SPhere to draw your Wire Sphere.
        Gizmos.DrawWireSphere(hitDetector.transform.position, hitRadius);
    }

    IEnumerator HammerHit()
    {
        _isHitting = true;

        hammer.GetComponent<Animator>().Play("hammerHit");

        yield return new WaitForSeconds(_animLength);

        hammer.GetComponent<Animator>().Play("New State");

        _isHitting = false;
    }
}

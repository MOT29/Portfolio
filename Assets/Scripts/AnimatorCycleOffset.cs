using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCycleOffset : MonoBehaviour
{
    Animator anim;
	
    void Start()
    {
        anim = GetComponent<Animator>();
		anim.SetFloat("offset", Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

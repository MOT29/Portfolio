using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCycleOffset : MonoBehaviour
{
    Animator anim;
	public float state;
	
    void Start()
    {
        anim = GetComponent<Animator>();
		anim.SetFloat("state", state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

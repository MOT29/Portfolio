using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMotion : MonoBehaviour
{
    public Vector3 moveDir;
    public Vector3 rotationDir;
	public float moveSpeed;
	public float rotationSpeed;
	public bool local;
	public bool pingpong;
	public float pingpongSize;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(!local) {
			transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
			transform.Rotate(rotationDir * rotationSpeed * Time.deltaTime, Space.World);
		} else {
			transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);
			transform.Rotate(rotationDir * rotationSpeed * Time.deltaTime, Space.Self);
		}
		if(pingpong) {
			rotationSpeed = Mathf.Lerp(pingpongSize, -pingpongSize, Mathf.PingPong(Time.time, 1));
			moveSpeed = Mathf.Lerp(pingpongSize, -pingpongSize, Mathf.PingPong(Time.time, 1));
		}
    }
	
	public void NegateRotDir() {
		rotationDir *= -1;
	}
	
	public void NegateMoveDir() {
		moveDir *= -1;
	}
	
	public void SetAnimatorState(int state) {
		GetComponent<Animator>().SetInteger("state", state);
	}
}

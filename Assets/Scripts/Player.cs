using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Info I;
	public float rayDistance;
	public CharacterController character;
	public float moveSpeed = 7f;
	public float runSpeed = 12f;
	public float jumpHeight = 15f;
	public float gravityScale = 5f;
	private bool grounded;
	private Vector3 motion;
    public int speedRotation = 1;
	private void Awake()
	{
	grounded = character.isGrounded;
	I = GameObject.Find("Info").GetComponent<Info>();
}
private void Update()
{
	if (grounded)
	motion.y = 0;
    CalculateMotion ();
	motion.y += gravityScale * Physics.gravity.y * Time.deltaTime;
	character.Move(motion * Time.deltaTime);
	grounded = character.isGrounded;
}
private void CalculateMotion()
{
	float currentHeight = motion.y;
	float verticalInput = Input.GetKey(I.WalkBackward)?-moveSpeed:Input.GetKey(I.WalkForward)?moveSpeed:0;
	float horizontalInput = Input.GetKey(I.WalkLeft)?-moveSpeed:Input.GetKey(I.WalkRight)?moveSpeed:0;
	transform.Translate(horizontalInput,0,verticalInput);
	motion = transform.forward * verticalInput + transform.right * horizontalInput;
	motion.Normalize();
	motion *= Input.GetKey(I.Sprint) ? runSpeed : moveSpeed;
    motion.y = currentHeight;
	if (grounded && Input.GetKeyDown(I.Jump))
	{
		motion.y = jumpHeight;
	}
}
}
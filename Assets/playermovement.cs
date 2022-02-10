using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour{

    public float Speed; 
    public float Jumppower;

    public LayerMask Mask;
    public Animator PlayerAnimator; 
    public SpriteRenderer SR;

private Rigidbody2D RB;  

private float startJumpPower;
private float startfastasfuckboi;
private bool _isGrounded;

    // Start is called before the first frame update
    void Start()  {
        RB = GetComponent<Rigidbody2D>();
        startJumpPower = Jumppower;
        startfastasfuckboi = Speed;
    }

    // Update is called once per frame
    void Update() {
        Vector2 movement = new Vector2(0, RB.velocity.y);

float DistanceToGround = GetComponent<Collider2D>().bounds.extents.y;

_isGrounded = Physics2D.Raycast(transform.position, Vector2.down, DistanceToGround+0.5f, Mask);




        if(Input.GetKey(KeyCode.A)){
            movement.x = -Speed*Time.deltaTime;
            }
        
        else if(Input.GetKey(KeyCode.D)) {
            movement.x = Speed*Time.deltaTime;
             }
        if(Input.GetKeyDown(KeyCode.W) && _isGrounded == true)
        {
            RB.AddForce(new Vector2(0,Jumppower));
            _isGrounded = false;
        }

        if(movement.x != 0){
            PlayerAnimator.SetBool("is moving", true);

        }
        else{
            PlayerAnimator.SetBool("is moving", false);
        }

        if(movement.x > 0){
            SR.flipX = false;
        }
        else{
            SR.flipX = true;
        }

        RB.velocity = movement; 
    }
  

    public void JumpPowerUp(float seconds, float jumppower){
            StartCoroutine(RunJumpPowerUp(seconds, jumppower));
    }
    IEnumerator RunJumpPowerUp(float seconds, float jumppower){
        Jumppower = jumppower;
        yield return new WaitForSeconds(seconds);
        Jumppower = startJumpPower;

    }

    public void SpeedPowerUp(float seconds, float fastassfuckboi)
    {
        StartCoroutine(RunSpeedBoost(seconds, fastassfuckboi));
    }
    IEnumerator RunSpeedBoost(float seconds, float fastassfuckboi){

        Speed = fastassfuckboi;
        yield return new WaitForSeconds(seconds); 
        Speed = startfastasfuckboi;
    }

}

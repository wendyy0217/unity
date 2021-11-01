using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigid2D;
    public GameObject missilePerfab;
    public Animator PlayerNarudomov;
    public float jumpForce = 30;
    public float speed_x_constraint;
    public SpriteRenderer spriteRenderer;


    void Start()
    {
      
        rigid2D = this.gameObject.GetComponent<Rigidbody2D>();


    }
    void Update()
    {
        bool isShooting = false;
        if (Input.GetKeyDown(KeyCode.C))
        {
            isShooting = true;
            Instantiate(missilePerfab, this.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = false;
            rigid2D.AddForce(new Vector2(0,47), ForceMode2D.Impulse);
            //rigid2D.AddForce(new Vector2(0, this.jumpForce), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isShooting = false;
            rigid2D.AddForce(new Vector2(400 * speed, 0), ForceMode2D.Force);
            //this.gameObject.transform.position += new Vector3(speed, 0, 0);
            spriteRenderer.flipX=false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isShooting = false;
            //增加力量
            rigid2D.AddForce(new Vector2(-200 * speed, 0), ForceMode2D.Force);
            //位移
            // this.gameObject.transform.position -= new Vector3(speed, 0, 0);
             spriteRenderer.flipX=true;
        }
        //角色滑行
        if(rigid2D.velocity.x>speed_x_constraint)
        {
            rigid2D.velocity= new Vector2(speed_x_constraint,rigid2D.velocity.y);
        }
        if(rigid2D.velocity.x>-speed_x_constraint)
        {
            rigid2D.velocity= new Vector2(-speed_x_constraint,rigid2D.velocity.y);
        }
        if (isShooting)
        {

           // if (PlayerNarudomov.GetInteger("Status") == 0)
                this.PlayerNarudomov.SetInteger("Status", 1);
                PlayerNarudomov.Play("narudo2020", 0, 0);

        }
        else
        {
            if (PlayerNarudomov.GetInteger("Status") == 1)
                PlayerNarudomov.SetInteger("Status", 0);

        }
    }
}

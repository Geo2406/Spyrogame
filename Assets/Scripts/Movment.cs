using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movment : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public Animator anim;

    public bool adminOn = false;
    public GameObject adminMode;
    public bool adminCanBeActivated;

    public Transform Hitpoint;
    public float radiusHit;
    public LayerMask Hit;
    public GameObject Enemy;

    public bool playerleft;

    public float jumpforce;
    public Transform feetpos;
    public LayerMask ground;
    public float checkradius;
    bool isgrounded;

    public GameObject Player;

    public float JumpTime;
    private float JumpTimeCounter;
    private bool isjumping;

   
    



    Realenemy enemyscript;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        isgrounded = true;
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);


        anim.SetFloat("Speed", Mathf.Abs(x));
      

      
        


       
       
      

        if(x > 0 && playerleft)
        {
            turn();
        }else if(x < 0 && !playerleft)
        {
            turn();
        }

        

      

    }

    

    void Attack()
    {
        anim.SetTrigger("DownAttack");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && adminOn == false && adminCanBeActivated == true)
        {
            adminOn = true;
            adminMode.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F9) && adminOn == true)
        {
            adminOn = false;
            adminMode.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R) && adminOn == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);           
        }
        if (Input.GetKeyDown(KeyCode.F2) && adminOn == true)
        {
            jumpforce = jumpforce +5;
        }
        if (Input.GetKeyDown(KeyCode.F3) && adminOn == true)
        {
            jumpforce = jumpforce - 5;
        }
        if (Input.GetKeyDown(KeyCode.F4) && adminOn == true)
        {
            checkradius = 10000;
        }


     







        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
            Collider2D[] enemies = Physics2D.OverlapCircleAll(Hitpoint.position, radiusHit, Hit);


            foreach(Collider2D enemy in enemies)
            {
                enemyscript = enemy.GetComponent<Realenemy>();
                enemyscript.Damage(1);
                
            }
        }

        void OnGizmosSelected()
        {
            Gizmos.DrawSphere(Hitpoint.position, radiusHit);
        }


        if (Input.GetKeyDown(KeyCode.Space) && isgrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;
            isgrounded = false;
            anim.SetBool("isgrounded", isgrounded);
            isjumping = true;
            JumpTimeCounter = JumpTime;
           
            

        }
        else if(isgrounded == false)
        {
            Player.GetComponent<Blocking>().enabled = false;
        }else if(isgrounded == true)
        {
            Player.GetComponent<Blocking>().enabled = true;
        }

        
        
        
        if (Input.GetKey(KeyCode.Space) && isjumping == true)
        {
            if(JumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpforce;
                JumpTimeCounter -= Time.deltaTime;
            }else
            {
                isjumping = false;
            }

           


        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            isjumping = false;
        }


        isgrounded = Physics2D.OverlapCircle(feetpos.position, checkradius, ground);
        anim.SetBool("isgrounded", isgrounded);
        anim.SetFloat("Vertical", rb.velocity.y);

    }

    public void turn()
    {
        playerleft = !playerleft;
        transform.Rotate(0, 180, 0);
        
    }

}

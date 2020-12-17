using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{


    public float starttimebtwshot;
    private float timebtwshots;
    public GameObject projectile;

    bool istouching;
    public float radius;
    public Transform center;
    public LayerMask Player;

    // Start is called before the first frame update
    void Start()
    {
        timebtwshots = starttimebtwshot;
    }

    // Update is called once per frame
    void Update()
    {


        istouching = Physics2D.OverlapCircle(center.position, radius, Player);

        
        void OnGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(center.position, radius);
        }
        
        
      if(istouching)
        {
            if (timebtwshots < 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);

                timebtwshots = starttimebtwshot;
            }
            else
            {
                timebtwshots -= Time.deltaTime;
            }
        }
        
        
    }

}

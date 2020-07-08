
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    
    public float speed  ;
    public bool movingRight = true;
    public GameObject playerCntrllr;
    public Animator animator;
    public bool isStanding;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStanding)
        {
            animator.SetBool("isStanding", false);
            if (movingRight)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
                transform.localScale = new Vector2(1, 1);

            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
                transform.localScale = new Vector2(-1, 1);

            }
        }
        else
        {
            animator.SetBool("isStanding", true);
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Turn"))
        {
            Debug.Log("Trigger");
            if (movingRight) movingRight = false;
            else movingRight = true;
        }
    }

     public void death()
    {
        this.enabled = false;
        Destroy(gameObject,1);
       
    }
}

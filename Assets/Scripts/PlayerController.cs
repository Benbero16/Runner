using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator myAnim;
    [SerializeField] public float speed;
    [SerializeField] public float shift;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(-shift, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(shift, 0, 0);
        }
       // rb.MovePosition(transform.position + Vector3.forward *  speed * Time.deltaTime);
       // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        /*  if (Input.GetKey(KeyCode.A))
          {
              myAnim.SetBool("Run", true);

          }
          else if (Input.GetKeyUp(KeyCode.A))
          {

              myAnim.SetBool("Run", false);


          }
          if (Input.GetKeyDown(KeyCode.Space))
          {

              myAnim.SetBool("Jump" , true);

          }
          else if (Input.GetKeyUp(KeyCode.Space))
          {
              myAnim.SetBool("Jump" , false);
          }
       */
    }
}

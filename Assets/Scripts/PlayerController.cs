using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] Rigidbody rb;
    [SerializeField] public Animator myAnim;
    [Tooltip("bu değişken oyuncunun hızını ifade eder.")] [SerializeField] public float speed;
    [Tooltip("bu değişken karakterin sağa ve sola x*2 kadar hareketini sağlar ")] [SerializeField] public float shift = 2; 
    [SerializeField] public bool isLeft, isMiddle, isRight;
    [HideInInspector] public string denemeforgizleme;
    [System.NonSerialized] public string denemeforgizleme_2;
    void notlar()
    {

        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);



        // transform translate ile ýþýnlama 
        //  transform.Translate(Vector3.forward*speed*Time.deltaTime);


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
              myAnim.SetBool("Jump", true);        
          }
          else if (Input.GetKeyUp(KeyCode.Space))
          {
              myAnim.SetBool("Jump", false);
          }

          */


        /*   if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && isLeft == false)

           {
               if (isMiddle)
               {
                   isLeft = true;
                   isMiddle = false;
               }
               else if (isRight)
               {
                   isMiddle = true;
                   isRight = false;
               }
               transform.Translate(new Vector3(-shift, 0, 0));
           }

           else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isRight == false)

           {
               if (isMiddle)
               {
                   isRight = true;
                   isMiddle = false;

               }
               else if (isLeft)
               {
                   isMiddle = true;
                   isLeft = false;
               }
               transform.Translate(new Vector3(shift, 0, 0));
           }

           */

    }
    void MoveCharacter()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        



        // 1.yöntem
        #region karakter sınırlama
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f)
        {
            transform.Translate(new Vector3(-shift, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f)
        {
            transform.Translate(shift, 0, 0);

        }
        #endregion
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMiddle = true;
        // transform.position= new Vector3 (0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
       

MoveCharacter();
    }

    private void FixedUpdate()
    {
        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);

    }

}
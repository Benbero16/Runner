using UnityEngine;
using DG.Tweening;
public class PlayerController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] Rigidbody rb;
    [SerializeField] public Animator myAnim;
    [Tooltip("bu değişken oyuncunun hızını ifade eder.")][SerializeField] public float speed;
    [Tooltip("bu değişken karakterin sağa ve sola x*2 kadar hareketini sağlar ")][SerializeField] public float shift = 2;
    [SerializeField] public bool isLeft, isMiddle, isRight;
    [HideInInspector] public string denemeforgizleme;
    [System.NonSerialized] public string denemeforgizleme_2;
    public int score;
    //bool ile sürünmeden kurtulalım
    public bool isDead;
    //oyun başladığında karakterin hareket etmemesi için
    [HideInInspector] public bool isStart;//public olmasının nedeni daha sonra buna UI managerda erişilmesi gerektiğidir.
    [SerializeField] public float floatScore;

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
        // Blok indexlerini kullanarak karakteri tam blok ortasına hizalayın
int currentLane = 1; // 0: sol, 1: orta, 2: sağ
float[] lanePositions = { -2f, 0f, 2f }; // Blokların x konumları

void MoveCharacter()
{
    if (isDeath) return;
    transform.Translate(Vector3.forward * speed * Time.deltaTime);

    if (Input.GetKeyDown(KeyCode.A) && currentLane > 0)
    {
        currentLane--;
        transform.DOMoveX(lanePositions[currentLane], 0.5f).SetEase(Ease.Linear);
    }
    else if (Input.GetKeyDown(KeyCode.D) && currentLane < lanePositions.Length - 1)
    {
        currentLane++;
        transform.DOMoveX(lanePositions[currentLane], 0.5f).SetEase(Ease.Linear);
    }
}





           */

    }
    void MoveCharacter()
    {


        if (!isStart) return;

        if (isDead) return;

        floatScore += Time.deltaTime;

        if (floatScore > 1)
        {
            score += 1;
            floatScore = 0;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // 1.yöntem
        #region karakter sınırlama
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f)
        {
            //transform.Translate(shift, 0, 0);

            transform.DOMoveX(transform.position.x - shift, 0.5f).SetEase(Ease.Linear);

        }

        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f)
        {

            transform.DOMoveX(transform.position.x + shift, 0.5f).SetEase(Ease.Linear);
        }

        #endregion
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMiddle = true;
        // transform.position= new Vector3 (0, 0, 5);
        //myAnim.SetBool("Run", true);
    }

    // Update is called once per frame
    void Update()
    {


        MoveCharacter();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("kaktus_1"))
        {
            Debug.Log("kaktus_1 çarptı" + other.gameObject.name);

            myAnim.SetBool("Death", true);
            isDead = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("money"))
        {
            Destroy(other.gameObject);
            score += 10;
            Debug.Log("Puan: " + score);
            // Burada para toplama puanını artırabilirsin
        }
    }



    private void FixedUpdate()
    {
        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);

    }

}
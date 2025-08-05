using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] road;// road ad�nda i�inde gameobject bar�nd�ran bir dizi tan�mlad�k.
    [SerializeField] Transform Player;
    [SerializeField] Transform roadParent;// dinamik olarak yollar� �zerinde olu�turaca��m�z obje(holder)
    float roadLength = 20; //Yol uzunlu�u
    int startRoadCount = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    { 
        Instantiate(road[0], transform.position, Quaternion.identity, roadParent);
        // bu komut temelde klon olu�turmaya yarar
        for (int i = 0; i < startRoadCount; i++)
        {

            GenerateRoad();


        }
    }
    private void Update()
    {
        if (Player.position.z > roadLength / 2)
        {
            GenerateRoad();
        }


    }

    void GenerateRoad()
    {
       
        for (int i = 0; i < startRoadCount; i++)
        {
            Instantiate(road[Random.Range(0, road.Length)], transform.position + new Vector3(0, 0, roadLength), Quaternion.identity, roadParent);
            roadLength += 20;
        }

    }
}

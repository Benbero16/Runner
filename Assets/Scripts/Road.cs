using UnityEngine;

public class Road : MonoBehaviour
{
    GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player.transform.position.z)-(this.transform.position.z ) > 25) { 
        Destroy(this.gameObject);
        
        
        }
    }
}

using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform Player;
    float zoffset;
    private void Start()
    {
        zoffset = transform.position.z-Player.position.z;
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y , Player.position.z+zoffset);
    }
}

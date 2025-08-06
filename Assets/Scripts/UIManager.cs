using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerController PlayerController;
    [SerializeField] public GameObject GameStartMenu;// start menü paneli için
    [SerializeField] public GameObject GameRestartMenu;// Restart menü Paneli için
    [SerializeField] public TextMeshProUGUI score;// restart de görünen
    [SerializeField] public TextMeshProUGUI mainScore;// her iki ekrandada görünen

    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start()
    {
        GameStartMenu.SetActive(true);// oyun baþladýðýnda startmenu paneli açýyor
        GameRestartMenu.SetActive(false);// oyun baþladýðýnda reStartMenu panelini kapatýyor.
    }

    // Update is called once per frame
 public void Update()
    {
        mainScore.text = "Score : " + PlayerController.score;

        if (PlayerController.isDead)
        {
            GameRestartMenu.SetActive(true);
            score.text = "Score : " + PlayerController.score;

        }

    }
    public void StartGame()
    {
        PlayerController.isStart = true;// oyun baþladý
        PlayerController.myAnim.SetBool("Run", true);
        GameStartMenu.SetActive(false);
    }

    public void RestartGame()
    {
        // SceneManager.LoadScene(0); çok dinamik deðil
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);// daha dinamik yapýdýr.

    }


}
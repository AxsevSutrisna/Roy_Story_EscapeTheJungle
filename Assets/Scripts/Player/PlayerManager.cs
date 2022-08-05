using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;

    /*public static Vector2 lastCheckPointPos = new Vector2(-3, 0);

    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;

    public CinemachineVirtualCamera VCam;
    public GameObject[] playerPrefabs;
    int characterIndex;*/

    private void Awake()
    {
        /*characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player = Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        VCam.m_Follow = player.transform;
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);*/
        isGameOver = false;

    }

    void Update()
    {
        //coinsText.text = numberOfCoins.ToString();
        if (isGameOver)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuScreen.SetActive(false);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject credits;

    public void Buttons (string value) {
        switch (value) {
            case "PLAY":
                SceneManager.LoadScene("Game");
                break;

            case "CREDITS":
                credits.SetActive(!credits.activeSelf);
                break;

            case "QUIT":
                Application.Quit ();
                break;
        }
    }
}
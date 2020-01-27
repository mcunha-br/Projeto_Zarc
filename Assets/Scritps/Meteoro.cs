using UnityEngine;

public class Meteoro : MonoBehaviour {

    private GameManager gameManager => FindObjectOfType<GameManager>();
    
    public float speed;
    public int score;


    private void Update() {
        transform.Rotate(0,0, gameManager.speed * speed * Time.deltaTime);
    }
}
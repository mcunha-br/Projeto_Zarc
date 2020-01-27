using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public Transform head;

    private Rigidbody2D body;
    private GameManager gameManager;
    private bool isJump;
    private RaycastHit2D hit2D;

    private void Start () {
        body = GetComponent<Rigidbody2D> ();
        gameManager = FindObjectOfType<GameManager> ();
    }

    private void Update () {
        if (isJump)
            transform.Translate (Vector2.up * speed * Time.deltaTime);

        if (Input.GetButtonDown ("Fire1") && !isJump) {
            body.isKinematic = false;
            transform.SetParent (null);
            isJump = true;
            gameManager.Jump++;
        }
    }

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag ("Meteoro")) {
            body.isKinematic = true;
            transform.position = other.transform.position;
            transform.up = other.transform.up;
            transform.SetParent (other.transform);
            isJump = false;
            gameManager.Score += other.GetComponent<Meteoro> ().score;
        }
    }

    private void OnBecameInvisible () {
        gameManager.GameOver ();
    }
}
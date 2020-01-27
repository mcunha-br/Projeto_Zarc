using UnityEngine;

public class MoveOffset : MonoBehaviour {

    public float speed;
    public Material material;

    private float offset;


    private void FixedUpdate() {
        offset += 0.001f;
        material.SetTextureOffset("_MainTex", new Vector2(0, offset * speed));
    }
    
}
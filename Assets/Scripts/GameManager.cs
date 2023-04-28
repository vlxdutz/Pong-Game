using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    // Referinta la proprietatea RigidBody2D
    public Rigidbody2D ball;

    // Start is called before the first frame update
    void Start() {
         if(instance == null){
            instance = this;
        } 
        
        InitializeBall();
    }

    public void InitializeBall() {
        ball.position = Vector3.zero;
        ball.velocity = Vector3.zero;

        // Setam o valoare aleatorie pentru x si y;
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(1.0f, 0.5f);

        Vector2 direction = new Vector2(x, y);

        ball.AddForce(direction * 325f);
    }
}

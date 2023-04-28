using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour {
    public bool isLeft;

    private KeyCode upKey;
    private KeyCode downKey;

    public float speed = 0.018f;
    // Start is called before the first frame update
    void Start() {
        // Verificam ce tasta e folosita in functie de paddle
        if(isLeft) {
            upKey = KeyCode.W;
            downKey = KeyCode.S;
        } else {
            upKey = KeyCode.UpArrow;
            downKey = KeyCode.DownArrow;
        }
    }

    // Update is called once per frame
    void Update() {
        // In functie de tasta apasata, miscam paddle-ul
        if(Input.GetKey(upKey)) {
            MoveUp();
        } else if(Input.GetKey(downKey)) {
            MoveDown();
        }
    }

    void MoveUp() {
        // Modoficam pozitia in sus cu viteza stabilita
        transform.Translate(Vector2.up * speed);

        if(transform.position.y > 4.25f) {
            Vector3  pos = transform.position;

            pos.y = 4.25f;
            transform.position = pos;
        }
    }

    void MoveDown() {
        // Modoficam pozitia in jos cu viteza stabilita
        transform.Translate(-Vector2.up * speed);

        if(transform.position.y < -4.25f) {
            Vector3  pos = transform.position;

            pos.y = -4.25f;
            transform.position = pos;
        }
    }
}

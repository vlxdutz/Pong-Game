using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {
    public bool isLeft;

    private void OnTriggerEnter2D(Collider2D other) {
        GameManager.instance.InitializeBall();
    }
}


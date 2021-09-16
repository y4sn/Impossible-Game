using UnityEngine;
public class PlayerMovement : MonoBehaviour { 
    
    void Update() { transform.Translate(5f * Time.deltaTime, 0f, 0f); } 
}

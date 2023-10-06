using UnityEngine;

public class PlayerController : MonoBehaviour {
    public SoccerBall ball;
    
    void Update() {
        // Assuming 'D' key for dribble for demonstration
        if (Input.GetKeyDown(KeyCode.D)) {
            DribbleBall();
        }
        // ... add other controls for shooting, passing, etc.
    }

    void DribbleBall() {
        ball.currentHolder = transform;
        // Rest of the dribble logic
    }

    // ... rest of the player script
}

using UnityEngine;

public class GoalieAI : MonoBehaviour {
    public Transform ball;
    public Transform goalCenter;
    public float diveSpeed = 5f;

    void Update() {
        Vector3 newPosition = new Vector3(ball.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 3);
    }

    public void OnBallShot(Vector3 shotDirection, float shotPower) {
        float thresholdPower = 10f;  
        float thresholdAngle = 45f;  
        if (shotPower < thresholdPower || Vector3.Angle(goalCenter.position - transform.position, shotDirection) < thresholdAngle) {
            CatchBall();
        } else {
            Dive(shotDirection);
        }
    }

    void CatchBall() {
        
        Destroy(ball.gameObject);
    }

    void Dive(Vector3 direction) {
        transform.Translate(direction.normalized * diveSpeed * Time.deltaTime);
    }
}

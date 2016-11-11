using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Rigidbody rb;
    public float start_health;
	public GameObject head;

	void Update () {
		rb.MovePosition(rb.position
			+transform.right*Input.GetAxis("Horizontal")
			+transform.forward*Input.GetAxis("Vertical"));
        if (start_health <= 0)
        {
            enabled = false;
        }
    }
    public float Distance(Vector3 pt)
    {
        return Vector3.Distance(transform.position, pt);
    }
    public void damage(float damage)
    {
        start_health -= damage;
    }
}

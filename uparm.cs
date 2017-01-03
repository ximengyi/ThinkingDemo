using System.Collections;

public class uparm : MonoBehaviour {
	public GameObject targetself;
	// Use this for initialization

	Vector3 currentPosition;
	Vector3 direction;
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		SwingRt ();
		//SwingFd();

		RoteToTarget(targetself.transform.position);
	}
	void SwingRt()
	{

		this.transform.RotateAround(targetself.transform.position, Vector3.forward, 45f * Time.deltaTime);
	}

	void SwingFd()
	{
		this.transform.RotateAround(targetself.transform.position, Vector3.right, 45f * Time.deltaTime);

	}

	void RoteToTarget(Vector3 targetPos)
	{

		currentPosition = this.transform.position;
		Quaternion currentRoation = this.transform.position;

		direction = (targetPos - currentPosition).normalized;
		Quaternion targetRotation = Quaternion.LookRotation (direction);
		transform.rotation = Quaternion.RotateTowards (currentRoation, targetRotation, 45 * Time.deltaTime);
	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Vector3 translateVector = new Vector3(0.0f, 2.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.Move();
    }

	void Move()
	{
		gameObject.transform.Translate(Time.deltaTime * translateVector, Space.World);
	}
}

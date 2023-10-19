using UnityEngine;
using System.Collections;
using UnityEngine.XR.iOS;


public class TouchManager : MonoBehaviour {

	public GameObject particle;
	RaycastHit hit = new RaycastHit();
	ConstantForce cF;

	[SerializeField]
	private UnityARHitTestExample unityARHitTest;

	void Update() {


		if (unityARHitTest.bPlaceObject == true) {
			return;
		}


		for (var i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {

				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (i).position);
				// Create a particle if hit
				if (Physics.Raycast (ray, out hit)) {

					//If we hit the sun move it
					if (hit.collider.gameObject.name == "sun") {
					
						cF = hit.collider.gameObject.GetComponent<ConstantForce> ();
						cF.force = new Vector3 (0.01f, 0, 0);
					
					}                
				}
			}
		}
	
}


	public void PlaceObjectMode(){

		unityARHitTest.bPlaceObject = !unityARHitTest.bPlaceObject;

	}
}

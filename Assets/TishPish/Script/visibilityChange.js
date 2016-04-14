#pragma strict

function Start () {

}

function Update () {
	 if (Input.GetKeyDown(KeyCode.Z)) 
	 {
	 GetComponent.<Renderer>().enabled = !GetComponent.<Renderer>().enabled;
    }
}


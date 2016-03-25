#pragma strict

function OnTriggerEnter2D(col:Collider2D){
	if (col.gameObject.CompareTag('Player')) {
		Destroy(col.gameObject);
		yield WaitForSeconds(0.05);
		Destroy(gameObject);
	}
}
#pragma strict

function Start () {
	for (var i = 0; i < Items.CollectionFlags.Length; i++){
		var go : GameObject = GameObject.Find(i.ToString());
		go.GetComponent(Image).enabled = false;
		go.GetComponent(Button).enabled = false;
		var secret : GameObject = go.transform.Find("Secret").gameObject;
		secret.GetComponent(Image).enabled = true;
		if(Items.CollectionFlags[i] == true){
			go.GetComponent(Image).enabled = true;
			go.GetComponent(Button).enabled = true;
			secret.GetComponent(Image).enabled = false;
		}
	}
}

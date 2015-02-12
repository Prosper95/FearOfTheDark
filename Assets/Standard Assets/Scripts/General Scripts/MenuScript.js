function OnMouseEnter()
{
	renderer.material.color = Color.grey;
	if(Input.GetMouseButtonDown (0)) {
		Application.LoadLevel ("1");
	}
}

function OnMouseExit ()
{
	renderer.material.color = Color.white;
}


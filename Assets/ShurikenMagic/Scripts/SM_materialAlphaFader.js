
var fadeSpeed:float=1;

var beginTintAlpha:float=0.5;

function Start () {


}

function Update () {

beginTintAlpha-=Time.deltaTime*fadeSpeed;

renderer.material.SetColor ("_TintColor", Color(1, 1, 1 ,beginTintAlpha));

}
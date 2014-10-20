var xspeed:float=1;
var yspeed:float=1.5;
var zspeed:float=2;

var speedDeviation:float=0;

var xDim:float=0.3;
var yDim:float=0.3;
var zDim:float=0.3;




function Start () {
transform.localPosition=Vector3(0, 0, 0);

xspeed+=(Random.Range(-1, 1)*speedDeviation);
yspeed+=(Random.Range(-1, 1)*speedDeviation);
zspeed+=(Random.Range(-1, 1)*speedDeviation);

}



function Update () {

transform.Translate(Vector3(xspeed,yspeed,zspeed)*Time.deltaTime);

if(transform.localPosition.x>xDim)
{
xspeed=-(Mathf.Abs(xspeed));
}

if(transform.localPosition.x<-xDim)
{
xspeed=Mathf.Abs(xspeed);
}

if(transform.localPosition.y>yDim)
{
yspeed=-(Mathf.Abs(yspeed));
}

if(transform.localPosition.y<-yDim)
{
yspeed=Mathf.Abs(yspeed);
}

if(transform.localPosition.z>zDim)
{
zspeed=-(Mathf.Abs(zspeed));
}

if(transform.localPosition.z<-zDim)
{
zspeed=Mathf.Abs(zspeed);
}






}
void Swinglr()
{
    //this.transform.RotateAround(target.transform.position, Vector3.up, 45f * Time.deltaTime);
    target.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
    float speed = 10f;
    float step = (speed * Time.deltaTime);
    transform.rotation = Quaternion.RotateTowards(this.transform.rotation, target.transform.rotation, step);


}







oid Swingfd()
    {
        //this.transform.Rotate(new Vector3(1, 3, 3), 45 * Time.deltaTime, Space.Self);

		//for (int i = 0; i < 90; i=i+10) {
		//	Quaternion quaternion = Quaternion.AngleAxis (i, Vector3.up);
		//	this.transform.rotation = quaternion;  
		//	yield return  WaitForSeconds (1.0);
		//}
	    
		Quaternion quaternion = Quaternion.AngleAxis (ang, Vector3.up);
		this.transform.rotation = quaternion;  
		ang = ang+30;
		if(ang>90){
			
			ang = ang - 60;	

		}
	    
    }

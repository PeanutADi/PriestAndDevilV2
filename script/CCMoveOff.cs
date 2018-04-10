using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMoveOff : SSAction {

	public UserAction Uaction;

	public string obj;

	public void setObj(string kind){
		Uaction = SDirector.getInstance ().currentSceneController as UserAction;
		this.obj = kind;
	}

	public void getOff () {
		if (obj == "priest") {
			Uaction.priestGetOff ();
		} else if (obj == "devil") {
			Uaction.devilGetOff ();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMoveOn : SSAction {

	public UserAction Uaction;

	public string obj;

	public void setObj(string kind){
		Uaction = SDirector.getInstance ().currentSceneController as UserAction;
		this.obj = kind;
	}

	public void getOn () {
		if (obj == "priest") {
			Uaction.priestGetOn ();
		} else if (obj == "devil") {
			Uaction.devilGetOn ();
		}
	}
}

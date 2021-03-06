/**
 * Copyright (C) 2005-2012 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;
using System.Collections;

//--------------------------------------
//  Class
//--------------------------------------
public class ScreenWrapComponent : MonoBehaviour {

	//--------------------------------------
	//  Properties
	//--------------------------------------
	private MoveHorizontallyLoopingComponent moveHorizontallyLoopingComponent;
	private float originalX;
	
	//--------------------------------------
	//  Methods
	//--------------------------------------		

	// Use this for initialization
	void Start () {
		moveHorizontallyLoopingComponent = GetComponent<MoveHorizontallyLoopingComponent>();
		originalX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		
		var x = transform.position.x;
		
				
		if (Mathf.Abs(moveHorizontallyLoopingComponent.direction_float) > 1) {
			//MOVING POSTIVE AND OFF THE SCREEN
			if (x > 100) {
				x = originalX;
			}
			
		} else {
			
			//MOVING POSTIVE AND OFF THE SCREEN
			//if (x < 0) {
		//		x = 100;
	//		}
		}
		
		transform.position = new Vector3 ( 
		
		x, 
		transform.position.y, 
		transform.position.z
		
		);

	
	}
	//--------------------------------------
	//  Events
	//--------------------------------------
}

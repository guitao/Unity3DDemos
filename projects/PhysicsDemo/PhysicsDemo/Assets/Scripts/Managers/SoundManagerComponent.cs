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
public class SoundManagerComponent : MonoBehaviour
{

	//--------------------------------------
	//  Properties
	//--------------------------------------
	
	///<summary>
	///	Define this...
	///</summary>
	private static AudioSource _AudioSource;
	
	///<summary>
	///	Define this...
	///</summary>
	private static float _VolumeScale_float;
	
	///<summary>
	///	AudioClip : When Lose Game
	///</summary>
	public static AudioClip AUDIO_CLIP_MOVE_FLYER_SOUND;

	
	//--------------------------------------
	//  Methods
	//--------------------------------------		
	///<summary>
	///	Use this for initialization
	///</summary>
	void Start () 
	{
		
		_VolumeScale_float = 100;
		//
		gameObject.AddComponent("AudioSource");
		_AudioSource = gameObject.GetComponent("AudioSource") as AudioSource;
		//
		AUDIO_CLIP_MOVE_FLYER_SOUND = Instantiate (Resources.Load("Sounds/MoveFlyerSound")) as AudioClip;

	}
	
	///<summary>
	///	Define this...
	///</summary>
	public static void PlayAudioClip (AudioClip aAudioClip) 
	{	
		_AudioSource.PlayOneShot (aAudioClip, _VolumeScale_float);
		
	}

	
	//--------------------------------------
	//  Events
	//--------------------------------------
	
	
}

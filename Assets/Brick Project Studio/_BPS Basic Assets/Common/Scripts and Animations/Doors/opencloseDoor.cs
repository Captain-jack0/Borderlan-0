using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		public AudioSource doorSoundSource;

		void Start()
		{
			open = false;
		}

		void OnMouseOver()
		{ 
			{
				if (Player)
				{
					
						if (open == false)
						{
							if (Input.GetMouseButtonDown(0))
							{
								
								StartCoroutine(opening());
								
														
							}
						}
						else
						{
							if (open == true)
							{
								if (Input.GetMouseButtonDown(0))
								{
									
									StartCoroutine(closing());
								}
							}

						}

					
				}

			}

		}

	IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			doorSoundSource.Play();
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			doorSoundSource.Play();
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
	


}
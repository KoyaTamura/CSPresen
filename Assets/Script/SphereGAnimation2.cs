using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SphereGAnimation2 : MonoBehaviour {

	public int mouseCount = 0;
	public bool flag = false;


	public Image magR;
	public Image magL;
	public Image drop;
	public Image hot;
	public Image ice;
	public Image hotAct;
	public Image iceAct;

	public Image car;
	public Image siphon;
	public Image hand;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		// count key space
		if(Input.GetKeyDown(KeyCode.Space)){
			mouseCount++;
			flag = true;
		}

		//move graph
		if (mouseCount == 1 && flag) {
			space1 ();
		} else if (mouseCount == 2 && flag) {
			space2 ();
		} else if (mouseCount == 3 && flag) {
			space3 ();
		} else if (mouseCount == 4 && flag) {
			space4 ();
		} else if (mouseCount == 5 && flag) {
			space5 ();
		}else if (mouseCount == 6 && flag) {
			space6 ();
		}else if (mouseCount == 7 && flag) {
			space7 ();
		}else if (mouseCount == 8 && flag) {
			space8 ();
		}else if (mouseCount == 9 && flag) {
			space9 ();
		}else if (mouseCount == 10 && flag) {
			space10 ();
		}
	}
		
	void space1(){
		DOTween.ToAlpha(() => magR.color, color => magR.color = color,1f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => magL.color, color => magL.color = color,1f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => drop.color, color => drop.color = color,1f,1f).SetEase(Ease.OutQuart);
		drop.transform.DOLocalMove(new Vector3(40f,-44.0f,0.0f) , 2f).SetEase(Ease.InQuart);
		StartCoroutine("waitTime");

		flag = false;
	}

	void space2(){
		DOTween.ToAlpha(() => hotAct.color, color => hotAct.color = color,0f,1f).SetEase(Ease.OutQuart);
		hotAct.transform.DOScale (new Vector2(0.7f,0.7f),1.0f).SetEase(Ease.OutQuart);
		StartCoroutine ("hotMove");

		flag = false;
	}

	void space3(){
		magL.transform.DOLocalMove(new Vector3(200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOLocalMove(new Vector3(200f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		ice.transform.DOLocalMove(new Vector3(-200f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		StartCoroutine ("iceMove");

		flag = false;
	}

	void space4(){
		magL.transform.DOLocalMove(new Vector3(200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOLocalMove(new Vector3(200f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		ice.transform.DOLocalMove(new Vector3(-200f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		
	}

	void space5(){
		magL.transform.DOLocalMove(new Vector3(200f,-40.0f+200f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f,-40.0f+200f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOLocalMove(new Vector3(200f,0.0f+200f,0.0f) , 1f).SetEase(Ease.OutQuart);
		ice.transform.DOLocalMove(new Vector3(-200f,0.0f+200f,0.0f) , 1f).SetEase(Ease.OutQuart);
		car.transform.DOLocalMove(new Vector3(-328f,-100.0f-50f,0.0f) , 1f).SetEase(Ease.OutQuart);
		siphon.transform.DOLocalMove(new Vector3(342f,-100.0f-50f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hand.transform.DOLocalMove(new Vector3(0f,0.0f-100f-60f,0.0f) , 1f).SetEase(Ease.OutQuart);

		DOTween.ToAlpha(() => car.color, color => car.color = color,1f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => siphon.color, color => siphon.color = color,1f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => hand.color, color => hand.color = color,1f,1f).SetEase(Ease.OutQuart);
		
	}

	void space6(){
		DOTween.ToAlpha(() => magL.color, color => magL.color = color,0f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => magR.color, color => magR.color = color,0f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => hot.color, color => hot.color = color,0f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => ice.color, color => ice.color = color,0f,1f).SetEase(Ease.OutQuart);

		car.transform.DOLocalMove(new Vector3(-328f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);
		siphon.transform.DOLocalMove(new Vector3(342f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hand.transform.DOLocalMove(new Vector3(0f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);

		car.transform.DOScale (new Vector2(1f,1.5f),1.0f).SetEase(Ease.OutQuart);
		siphon.transform.DOScale (new Vector2(1f,2f),1.0f).SetEase(Ease.OutQuart);
		hand.transform.DOScale (new Vector2(1.5f,1.5f),1.0f).SetEase(Ease.OutQuart);
		
	}

	void space7(){
		car.transform.DOScale (new Vector2(1.5f,2.25f),1.0f).SetEase(Ease.OutQuart);
		car.transform.DOLocalMove(new Vector3(-328f,200f,0.0f) , 1f).SetEase(Ease.OutQuart);
	}	

	void space8(){
		car.transform.DOScale (new Vector2(1.0f,1.5f),1.0f).SetEase(Ease.OutQuart);
		car.transform.DOLocalMove(new Vector3(-328f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);

		siphon.transform.DOScale (new Vector2(1.5f,3f),1.0f).SetEase(Ease.OutQuart);
		siphon.transform.DOLocalMove(new Vector3(342f,200f,0.0f) , 1f).SetEase(Ease.OutQuart);
	}

	void space9(){
		siphon.transform.DOScale (new Vector2(1.0f,2.0f),1.0f).SetEase(Ease.OutQuart);
		siphon.transform.DOLocalMove(new Vector3(342f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);

		hand.transform.DOScale (new Vector2(2.25f,2.25f),1.0f).SetEase(Ease.OutQuart);
		hand.transform.DOLocalMove(new Vector3(0f,200f,0.0f) , 1f).SetEase(Ease.OutQuart);
	}

	void space10(){
		hand.transform.DOScale (new Vector2(1.5f,1.5f),1.0f).SetEase(Ease.OutQuart);
		hand.transform.DOLocalMove(new Vector3(0f,220f,0.0f) , 1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => car.color, color => car.color = color,0f,3f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => siphon.color, color => siphon.color = color,0f,3f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => hand.color, color => hand.color = color,0f,3f).SetEase(Ease.OutQuart);
	}


	IEnumerator waitTime(){
		yield return new WaitForSeconds (2.0f);
		DOTween.ToAlpha(() => drop.color, color => drop.color = color,0f,0.1f).SetEase(Ease.OutQuart);
		magL.transform.DOLocalMove(new Vector3(200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOScale (new Vector2(0.5f,0.5f),1.0f).SetEase(Ease.OutQuart);
		ice.transform.DOScale (new Vector2(0.5f,0.5f),1.0f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => hot.color, color => hot.color = color,0.25f,1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => ice.color, color => ice.color = color,0.25f,1f).SetEase(Ease.OutQuart);
	}

	IEnumerator hotMove(){
		yield return new WaitForSeconds (1.5f);
		magL.transform.DOLocalMove(new Vector3(200f-500f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f-500f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOLocalMove(new Vector3(200f-500f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		ice.transform.DOLocalMove(new Vector3(-200f-500f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);

	}

	IEnumerator iceMove(){
		yield return new WaitForSeconds (1.0f);

		DOTween.ToAlpha(() => iceAct.color, color => iceAct.color = color,0f,1f).SetEase(Ease.OutQuart);
		iceAct.transform.DOScale (new Vector2(0.7f,0.7f),1.0f).SetEase(Ease.OutQuart);

		yield return new WaitForSeconds (1.5f);

		magL.transform.DOLocalMove(new Vector3(200f+500f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		magR.transform.DOLocalMove(new Vector3(-200f+500f,-40.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		hot.transform.DOLocalMove(new Vector3(200f+500f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		ice.transform.DOLocalMove(new Vector3(-200f+500f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);

	}

}

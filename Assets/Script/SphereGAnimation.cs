using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SphereGAnimation : MonoBehaviour {

	public int mouseCount = 0;
	public bool flag = false;

	public Image water;
	public Image center;
	public Image coffee;

	public Image sweet;
	public Image acidity;
	public Image body;
	public GameObject rotateObj;


	// Use this for initialization
	void Start () {
		water.fillAmount = 0f;
		center.fillAmount = 0f;
		coffee.fillAmount = 0f;
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
		}
	}


	void space1(){
		DOTween.To (() => water.fillAmount , (x) => water.fillAmount = x , 0.98f , 1.3f).SetEase(Ease.OutQuart);
		DOTween.To (() => center.fillAmount , (x) => center.fillAmount = x , 1f , 1f).SetEase(Ease.OutQuart);
		DOTween.To (() => coffee.fillAmount , (x) => coffee.fillAmount = x , 1f , 1.2f).SetEase(Ease.OutQuart).OnComplete(()=>{

			water.transform.DOMove (new Vector2(-2.4f,0f) , 0.5f).SetEase(Ease.OutQuart);
			center.transform.DOMove (new Vector2(-2.4f,0f) , 0.5f).SetEase(Ease.OutQuart);
			coffee.transform.DOMove (new Vector2(-2.4f,0f) , 0.5f).SetEase(Ease.OutQuart);

		});
		flag = false;
	}


	void space2(){
		center.transform.DOScale (new Vector2(0f,0f),2f).SetEase(Ease.OutQuart);
		DOTween.To (() => water.fillAmount , (x) => water.fillAmount = x , 0f , 1.3f).SetEase(Ease.OutQuart);
		coffee.transform.DOScale (new Vector2(1.1f,1.1f),2f).SetEase(Ease.OutQuart);
		water.transform.DOMove (new Vector2(0f,0f) , 0.5f).SetEase(Ease.OutQuart);
		center.transform.DOMove (new Vector2(0f,0f) , 0.5f).SetEase(Ease.OutQuart);
		coffee.transform.DOMove (new Vector2(0f,0f) , 0.5f).SetEase(Ease.OutQuart).OnComplete(()=>{

		});

		flag = false;
	}


	void space3(){
		DOTween.ToAlpha(() => coffee.color, color => coffee.color = color,0f,1f).SetEase(Ease.OutQuart);
		coffee.transform.DOScale (new Vector2(0f,0f),1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => sweet.color, color => sweet.color = color,1f,3f).SetEase(Ease.OutQuart);
		sweet.transform.DOScale (new Vector2(0.3f,0.3f),2f).SetEase(Ease.OutQuart);
		sweet.transform.DOMove (new Vector2(0f,2f) , 1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => acidity.color, color => acidity.color = color,1f,3f).SetEase(Ease.OutQuart);
		acidity.transform.DOScale (new Vector2(0.3f,0.3f),2f).SetEase(Ease.OutQuart);
		acidity.transform.DOMove (new Vector2(-1.8f,-1f) , 1f).SetEase(Ease.OutQuart);
		DOTween.ToAlpha(() => body.color, color => body.color = color,1f,3f).SetEase(Ease.OutQuart);
		body.transform.DOScale (new Vector2(0.3f,0.3f),2f).SetEase(Ease.OutQuart);
		body.transform.DOMove (new Vector2(1.8f,-1f) , 1f).SetEase(Ease.OutQuart);

		flag = false;
	}

	void space4(){
		rotateObj.transform.DOLocalMove(new Vector3(-200f,0.0f,0.0f) , 1f).SetEase(Ease.OutQuart);
		rotateObj.transform.DORotate(new Vector3(0f, 0f, 150f),1.0f).SetEase(Ease.OutQuart);
		acidity.transform.DOScale (new Vector2(0.4f,0.4f),1.0f).SetEase(Ease.OutQuart);

		flag = false;
	}

	void space5(){
		rotateObj.transform.DORotate(new Vector3(0f, 0f, 270f),1.0f).SetEase(Ease.OutQuart);
		sweet.transform.DOScale (new Vector2(0.4f,0.4f),1.0f).SetEase(Ease.OutQuart);
		acidity.transform.DOScale (new Vector2(0.3f,0.3f),1.0f).SetEase(Ease.OutQuart);
	
		flag = false;
	}

	void space6(){
		rotateObj.transform.DORotate(new Vector3(0f, 0f, 390f),1.0f).SetEase(Ease.OutQuart);
		body.transform.DOScale (new Vector2(0.4f,0.4f),1.0f).SetEase(Ease.OutQuart);
		sweet.transform.DOScale (new Vector2(0.3f,0.3f),1.0f).SetEase(Ease.OutQuart);

		flag = false;
	}

	void space7(){
		rotateObj.transform.DOLocalMove(new Vector3(0f,0.0f,0.0f) , 2f).SetEase(Ease.OutQuart);
		rotateObj.transform.DORotate(new Vector3(0f, 0f, 3000f),1.5f,RotateMode.FastBeyond360).SetEase(Ease.InQuart);

		DOTween.ToAlpha(() => sweet.color, color => sweet.color = color,0f,2f);
		//sweet.transform.DOScale (new Vector2(1f,1f),4f).SetEase(Ease.OutQuart);

		DOTween.ToAlpha(() => acidity.color, color => acidity.color = color,0f,2f);
		//acidity.transform.DOScale (new Vector2(1f,1f),4f).SetEase(Ease.OutQuart);

		DOTween.ToAlpha(() => body.color, color => body.color = color,0f,2f);
		body.transform.DOScale (new Vector2(0.3f,0.3f),1.0f).SetEase(Ease.OutQuart);
		//body.transform.DOScale (new Vector2(1f,1f),4f).SetEase(Ease.OutQuart);

		flag = false;
	}

	void space8(){

		flag = false;
	}
}

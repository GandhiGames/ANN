using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Simulation;

[RequireComponent (typeof(NeuralNetController), typeof(Utilities))]
public class ANNTest : MonoBehaviour
{
	private NeuralNetController _netController;
	
	void Start ()
	{
		_netController = GetComponent<NeuralNetController> ();
	}

	void Update ()
	{
		Utilities.instance.PrettyPrint (_netController.UpdateNeuralNet (Utilities.instance.RandomInputBuilder (_netController)));
	}
}

using System.Collections;
using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Text;

public class SerialPortReciever : MonoBehaviour
{

	private SerialPort sp;
	private Queue<string> queueDataPool;
	private Thread tPort;
	private Thread tPortDeal;
	private string strOutPool = string.Empty;
	string finalstring = string.Empty;
	string tempstring = string.Empty;
	// Use this for initialization
	void Start()
	{
		queueDataPool = new Queue<string>();
		sp = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
		if (!sp.IsOpen)
		{
			sp.Open();
		}
		tPort = new Thread(DealData);
		tPort.Start();
		tPortDeal = new Thread(ReceiveData);
		tPortDeal.Start();
	}

	// Update is called once per frame
	void Update()
	{
		if (!tPortDeal.IsAlive)
		{
			tPortDeal = new Thread(ReceiveData);
			tPortDeal.Start();
		}
		if (!tPort.IsAlive)
		{
			tPort = new Thread(DealData);
			tPort.Start();
		}

}

	private void ReceiveData()
	{
		try
		{
			Byte[] buf = new Byte[1];
			string sbReadline2str = string.Empty;
			if (sp.IsOpen) sp.Read(buf, 0, 1);
			if (buf.Length == 0)
			{
				return;
			}
			if (buf != null)
			{
				for (int i = 0; i < buf.Length; i++)
				{
					sbReadline2str += buf[i].ToString("X2");
					queueDataPool.Enqueue(sbReadline2str);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex);
		}
	}
	private void DealData()
	{
		while (queueDataPool.Count != 0)
		{
			for (int i = 0; i < queueDataPool.Count; i++)
			{
				strOutPool+= queueDataPool.Dequeue();
				if(strOutPool.Length==16)
				{
					Debug.Log(strOutPool);
					strOutPool=string.Empty;
				}
			}

		}
	}

	private void SendSerialPortData(string data)
	{
		if(sp.IsOpen)
		{
			sp.WriteLine(data);
		}
	}

	void OnApplicationQuit()
	{
		sp.Close();
	}
}

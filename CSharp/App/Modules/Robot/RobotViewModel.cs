﻿using System;
using System.ComponentModel.Composition;
using System.Windows.Threading;
using Log;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using ENet;

namespace Modules.Robot
{
	[Export(contractType: typeof (RobotViewModel)), PartCreationPolicy(creationPolicy: CreationPolicy.NonShared)]
	internal class RobotViewModel : NotificationObject
	{
		private readonly Host host;
		private string logText = "";
		private readonly DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Normal)
		{
			Interval = new TimeSpan(0, 0, 0, 0, 50)
		};

		public string LogText
		{
			get
			{
				return this.logText;
			}
			set
			{
				if (this.logText == value)
				{
					return;
				}
				this.logText = value;
				this.RaisePropertyChanged("LogText");
			}
		}

		public RobotViewModel()
		{
			Library.Initialize();
			host = new Host(8888, Native.ENET_PROTOCOL_MAXIMUM_PEER_ID);

			timer.Tick += delegate { this.host.Run(); };
			timer.Start();
		}

		public async void StartClient()
		{
			try
			{
				Peer peer = await host.ConnectAsync(new Address { Host = "192.168.10.246", Port = 8901 });
			}
			catch (ENetException e)
			{
				Logger.Debug(e.Message);
			}
		}

		public void Start()
		{
			Logger.Trace("11111111111111111111111");
			//for (int i = 0; i < 4095; ++i)
			//{
			//	StartClient();
			//}
		}
	}
}
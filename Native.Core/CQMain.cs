﻿using Native.Sdk.Cqp.Interface;
using Nekonya.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Nekonya;
using Nekonya.DBs;

namespace Native.Core
{
	/// <summary>
	/// 酷Q应用主入口类
	/// </summary>
	public class CQMain
	{
		/// <summary>
		/// 在应用被加载时将调用此方法进行事件注册, 请在此方法里向 <see cref="IUnityContainer"/> 容器中注册需要使用的事件
		/// </summary>
		/// <param name="container">用于注册的 IOC 容器 </param>
		public static void Register (IUnityContainer unityContainer)
		{
			unityContainer.RegisterType<IGroupMessage, GroupMessage>("group_msg");
			unityContainer.RegisterType<IPrivateMessage, PersonMessage>("person_msg");
			//unityContainer.RegisterInstance(typeof(EVEGameDB), "EVEDB", new EVEGameDB());
		}
	}
}

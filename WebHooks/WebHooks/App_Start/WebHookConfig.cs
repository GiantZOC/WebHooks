﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebHooks.App_Start
{
	public static class WebHookConfig
	{
		public static void Register(HttpConfiguration config) {
			config.InitializeReceiveGitHubWebHooks();
		}
	}
}
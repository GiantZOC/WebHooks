using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebHooks.Models;
using WebHooks.Repositories;

namespace WebHooks.Controllers
{
	public class ActivitiesController : ApiController
	{
		GitHubActivitiesRepository repository;

		public ActivitiesController() {
			repository = new GitHubActivitiesRepository();
		}

		public IEnumerable<GitHubActivity> GetAllActivities() {
			return repository.GetAllActivities();
		}

		public IEnumerable<GitHubActivity> GetActivitiesAfter(int id) {
			return repository.GetActivitiesAfter(id);
		}
	}
}
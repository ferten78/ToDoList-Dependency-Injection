using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Business.Abstaract;
using ToDoList.WebUI.Models;

namespace ToDoList.WebUI.Controllers
{
    public class JobsController : Controller
    {
        private IJobService _jobService;
        private IUserService _userService;
        private IStatusService _statusService;

        public JobsController(IJobService jobService, IUserService userService, IStatusService statusService)
        {
            _jobService = jobService;
            _userService = userService;
            _statusService = statusService;
        }
        public ActionResult JobList()
        {
            bool isLate = false;
            var jobs = _jobService.GetAll();

            foreach (var item in jobs)
            {
                if (item.finishDate < DateTime.Now)
                {
                    isLate = true;
                }
            }
            var model = new JobsListViewModel
            {
                Jobs = jobs,
                Users = _userService.GetAll(),
                Statuses = _statusService.GetAll(),
                IsLate = isLate
            };

            return View(model);
        }

        public ActionResult NewJob()
        {
            var model = new NewJobViewModel
            {
                Users = _userService.GetAll(),
                Statuses = _statusService.GetAll()
            };

            return View(model);
        }
        public ActionResult EditJob(int Id)
        {
            var job = _jobService.GetById(Id);
            var model = new EditJobViewModel
            {
                Job = job,
                Users = _userService.GetAll(),
                Status = _statusService.GetAll()
            };

            return View(model);
        }

        public JsonResult addJob(int Id, DateTime date, string description)
        {
            //Validasyonlar eksik
            try
            {
                _jobService.Add(new Entities.Concrete.Job
                {
                    description = description,
                    finishDate = date,
                    userId = Id,
                    statusId = 1
                });


                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult updateJob(int Id, DateTime date, string description, int statusId, int UserId)
        {
            //Validasyonlar eksik
            try
            { 
                var job = _jobService.GetById(Id);

                job.finishDate = date;
                job.description = description;
                job.statusId = statusId;
                job.userId = UserId;

                _jobService.Update(job);


                return Json(true, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            { 
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult deleteJob(int Id)
        {
            try
            {
                var job = _jobService.GetById(Id);
                _jobService.Delete(job);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
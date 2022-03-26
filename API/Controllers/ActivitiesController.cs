using Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;

using Application.Activities;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await   Mediator.Send(new List.Query()); // List needs using application activities
        }

        [HttpGet("{id}")] // activity id
        public async Task<ActionResult<Activity>>GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
            //return Ok();
        }

    }
}
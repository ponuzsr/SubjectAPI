﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SubjectAPI.Models
{
    [Route("subjects")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Subject> Post(CreateSubjectDto createSubjectDto)
        {
            var subject = new Subject()
            {
                Id = Guid.NewGuid(),
                SubjectName = createSubjectDto.SubjectName,
                NumberOfHours = createSubjectDto.NumberOfHours,
                Description = createSubjectDto.Description,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now
            };
            if (subject != null)
            {
                using (var context = new SubjectDbContext())
                {
                    context.Subjects.Add(subject);
                    context.SaveChanges();
                    return StatusCode(201, subject);

                }
            }
            return BadRequest();
        }
        [HttpGet]
        public ActionResult<Subject> Get()
        {
                using(var context = new SubjectDbContext())
            {
                return Ok(context.Subjects.ToList());
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Subject> Get(Guid id)
        {
            using(var context = new SubjectDbContext())
            {
                var subject = context.Subjects.SingleOrDefault(x => x.Id == id);
                if (subject == null)
                {
                    return Ok(subject);
                }
                return NotFound();
            }
        }

    }
}
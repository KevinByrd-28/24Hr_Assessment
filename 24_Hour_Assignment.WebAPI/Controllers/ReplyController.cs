using _24_Hour_Assignment.Models;
using _24_Hour_Assignment.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24_Hour_Assignment.WebAPI.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {
        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ReplyService = new ReplyService(userId);
            return ReplyService;
        }

        public IHttpActionResult Get()
        {
            ReplyService ReplyService = CreateReplyService();
            var Replies = ReplyService.GetReplies();
            return Ok(Replies);
        }


        public IHttpActionResult Reply(ReplyCreate Reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(Reply))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(ReplyEdit Reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.UpdateReply(Reply))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateReplyService();

            if (!service.DeleteReply(id))
                return InternalServerError();

            return Ok();
        }
    }
}

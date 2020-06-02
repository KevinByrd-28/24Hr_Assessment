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
    public class LikeController : ApiController
    {
        private LikeService CreateLikeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var postService = new LikeService(userId);
            return postService;
        }

        public IHttpActionResult Get()
        {
            LikeService postService = CreateLikeService();
            var posts = postService.GetLikes();
            return Ok(posts);
        }

        public IHttpActionResult Like(LikeCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikeService();

            if (!service.CreateLike(post))
                return InternalServerError();

            return Ok();
        }

        
        public IHttpActionResult Delete(int id)
        {
            var service = CreateLikeService();

            if (!service.DeleteLike(id))
                return InternalServerError();

            return Ok();
        }
    }
}

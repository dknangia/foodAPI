using Food.Models;
using Food.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.Filters;

namespace Food.Controllers
{
    
    public class FoodsController : ApiController
    {
        private readonly IFoodRepository _foodRepository;

        public FoodsController(IFoodRepository repo)
        {
            _foodRepository = repo;
        }

     
        [HttpGet]
        public HttpResponseMessage Get()
        {
            IList<FoodModel> result = null;
            try
            {
                result = _foodRepository.GetFood();
                if (result != null)
                    foreach (var item in result)
                    {
                        item.URL = (new UrlHelper(Request)).Link("Foods", new {foodId = item.ID});
                    }
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return result == null || !result.Any() ? Request.CreateResponse(HttpStatusCode.NotFound) : Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpGet]
        public HttpResponseMessage Get(int foodId)
        {

            FoodModel result;
            try
            {
                result = _foodRepository.GetFood(foodId);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return result == null ? Request.CreateResponse(HttpStatusCode.NotFound, new { success = true, message = "Record is not found" })
                : Request.CreateResponse(HttpStatusCode.OK, new { success = true, data = result });
        }

        [HttpPost]
        public HttpResponseMessage Post(FoodModel toSave)
        {
            if (toSave != null)
            {
                FoodModel model = _foodRepository.SaveFood(toSave);
                model.URL = (new UrlHelper(Request)).Link("Foods", new { foodId = model.ID });
                return Request.CreateResponse(HttpStatusCode.Created, model);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "Request is null or in bad format" });
            }

        }



    }
}

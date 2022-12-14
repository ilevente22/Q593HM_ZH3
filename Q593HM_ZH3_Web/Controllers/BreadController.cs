using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Q593HM_ZH3_Web.Models;

namespace Q593HM_ZH3_Web.Controllers
{
    [Route("api/Bread")]
    [ApiController]
    public class BreadController : ControllerBase
    {
        [HttpGet]
        public IActionResult getössz()
        {
            BreadOrderContext context = new BreadOrderContext();
            return Ok(context.Breads.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult getegy(int id)
        {
            BreadOrderContext context = new BreadOrderContext();
            var kenyér = (from x in context.Breads
                          where x.BreadId == id
                          select x).FirstOrDefault();
            return Ok(kenyér);
        }

        [HttpPost]
        public void újkenyér([FromBody] Bread újkenyér)
        {
            BreadOrderContext context = new BreadOrderContext();
            

            try
            {
                context.Breads.Add(újkenyér);
                context.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        [HttpDelete("{id}")]
        public void törlés(int id)
        {
            BreadOrderContext context = new BreadOrderContext();
            var kenyér = (from x in context.Breads
                          where x.BreadId == id
                          select x).FirstOrDefault();

            try
            {
                context.Breads.Remove(kenyér);
                context.SaveChanges();
            }
            catch (Exception)
            {

            }
            
        }
    }
}

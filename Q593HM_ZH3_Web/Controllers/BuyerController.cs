using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Q593HM_ZH3_Web.Models;

namespace Q593HM_ZH3_Web.Controllers
{
    [Route("api/Buyer")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        [HttpGet]
        public IActionResult getössz()
        {
            BreadOrderContext context = new BreadOrderContext();
            return Ok(context.Buyers.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult getegy(int id)
        {
            BreadOrderContext context = new BreadOrderContext();
            var vásárló = (from x in context.Buyers
                          where x.BuyerId == id
                          select x).FirstOrDefault();
            return Ok(vásárló);
        }

        [HttpPost]
        public void újvásárló([FromBody] Buyer újvásárló)
        {
            BreadOrderContext context = new BreadOrderContext();
            try
            {
                context.Buyers.Add(újvásárló);
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
            var vásárló = (from x in context.Buyers
                          where x.BuyerId == id
                          select x).FirstOrDefault();

            try
            {
                context.Buyers.Remove(vásárló);
                context.SaveChanges();
            }
            catch (Exception) 
            {
            
            
            }
           
            
        }
    }
}

